using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinaleFode2025
{
    public partial class frmMaisons: Form
    {
        public frmMaisons()
        {
            InitializeComponent();
        }
        DataSet ds;
        SqlDataAdapter adpMaisons;
        SqlDataAdapter adpAgents;
        SqlDataAdapter adpVendeurs;
        DataTable tabMaisons;

        int indexcourant;
        string mode = ""; // ajout ou modif

        string cnx = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjetFinalBD;Integrated Security=True";
        private void frmMaisons_Load(object sender, EventArgs e)
        {
            ds = new DataSet();

            // MAISONS
            adpMaisons = new SqlDataAdapter("SELECT * FROM Maison", cnx);
            adpMaisons.Fill(ds, "Maison");
            tabMaisons = ds.Tables["Maison"];

            // AGENTS UNIQUEMENT (Type = Agent)
            adpAgents = new SqlDataAdapter(
                "SELECT idEmployee, Nom FROM Employees WHERE Type = 'Agent'", cnx);
            adpAgents.Fill(ds, "Agents");

            // VENDEURS UNIQUEMENT
            adpVendeurs = new SqlDataAdapter(
                "SELECT idClient, Nom FROM Client WHERE TypeClient = 'Vendeur'", cnx);
            adpVendeurs.Fill(ds, "Vendeurs");

            RemplirComboAgent();
            RemplirComboVendeur();

            indexcourant = 0;
            AfficherTabDansTextbox();
            MontrerBoutons(true, false);
        }
        private void AfficherTabDansTextbox()
        {
            if (tabMaisons == null || tabMaisons.Rows.Count == 0)
            {
                lblInfo.Text = "Aucune maison trouvée";
                return;
            }

            txtnumMais.Text = tabMaisons.Rows[indexcourant]["Numero"].ToString();
            txtRefMais.Text = tabMaisons.Rows[indexcourant]["Reference"].ToString();
            txtAdrMais.Text = tabMaisons.Rows[indexcourant]["Adresse"].ToString();
            txtPrix.Text = tabMaisons.Rows[indexcourant]["Prix"].ToString();

            cboAgent.SelectedValue = tabMaisons.Rows[indexcourant]["idEmployee"];
            cboVendeur.SelectedValue = tabMaisons.Rows[indexcourant]["idClient"];

            lblInfo.Text = "Maison " + (indexcourant + 1) +
                           " sur un total de " + tabMaisons.Rows.Count;
        }
        private void MontrerBoutons(bool btnAjModSup, bool btnSavAn)
        {
            btnAjouter.Visible = btnModifier.Visible = btnSupprimer.Visible = btnAjModSup;
            btnSauvgarder.Visible = btnAnnuler.Visible = btnSavAn;
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            mode = "ajout";

            txtnumMais.Text = txtRefMais.Text = txtAdrMais.Text = txtPrix.Text = "";
            cboAgent.SelectedIndex = -1;
            cboVendeur.SelectedIndex = -1;

            txtnumMais.Focus();
            lblInfo.Text = "En mode ajout d’une nouvelle maison";

            MontrerBoutons(false, true);

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            mode = "modif";
            txtnumMais.Enabled = false;

            txtRefMais.Focus();
            lblInfo.Text = "En mode modification de la maison courante";

            MontrerBoutons(false, true);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Supprimer cette maison ?", "Confirmation",
    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tabMaisons.Rows[indexcourant].Delete();

                SqlCommandBuilder builder = new SqlCommandBuilder(adpMaisons);
                adpMaisons.Update(ds, "Maison");

                indexcourant = 0;
                AfficherTabDansTextbox();
            }
        }

        private void btnSauvgarder_Click(object sender, EventArgs e)
        {
            string num = txtnumMais.Text.Trim();
            string reference = txtRefMais.Text.Trim();
            string adresse = txtAdrMais.Text.Trim();
            double prix = Convert.ToDouble(txtPrix.Text);
            int idAgent = Convert.ToInt32(cboAgent.SelectedValue);
            int idVendeur = Convert.ToInt32(cboVendeur.SelectedValue);

            if (mode == "ajout")
            {
                DataRow row = tabMaisons.NewRow();
                row["Numero"] = num;
                row["Reference"] = reference;
                row["Adresse"] = adresse;
                row["Prix"] = prix;
                row["IdEmploye"] = idAgent;
                row["IdClient"] = idVendeur;

                tabMaisons.Rows.Add(row);
                indexcourant = tabMaisons.Rows.Count - 1;
            }
            else if (mode == "modif")
            {
                DataRow row = tabMaisons.Rows[indexcourant];
                row["Reference"] = reference;
                row["Adresse"] = adresse;
                row["Prix"] = prix;
                row["IdEmploye"] = idAgent;
                row["IdClient"] = idVendeur;
            }

            SqlCommandBuilder builder = new SqlCommandBuilder(adpMaisons);
            adpMaisons.Update(ds, "Maison");

            txtnumMais.Enabled = true;
            AfficherTabDansTextbox();
            MontrerBoutons(true, false);

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtnumMais.Enabled = true;
            AfficherTabDansTextbox();
            MontrerBoutons(true, false);
        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            indexcourant = 0;
            AfficherTabDansTextbox();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if (indexcourant > 0)
            {
                indexcourant--;
                AfficherTabDansTextbox();
            }

        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if(indexcourant < tabMaisons.Rows.Count - 1)
            {
                indexcourant++;
                AfficherTabDansTextbox();
            }

        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            indexcourant = tabMaisons.Rows.Count - 1; ;
            AfficherTabDansTextbox();
        }
        private void RemplirComboAgent()
        {
            cboAgent.DataSource = ds.Tables["Agents"];
            cboAgent.DisplayMember = "Nom";
            cboAgent.ValueMember = "idEmployee";
        }
        private void RemplirComboVendeur()
        {
            cboVendeur.DataSource = ds.Tables["Vendeurs"];
            cboVendeur.DisplayMember = "Nom";
            cboVendeur.ValueMember = "idClient";
        }


    }
}
