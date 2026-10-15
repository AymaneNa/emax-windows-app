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
    public partial class frmClient: Form
    {
        public frmClient()
        {
            InitializeComponent();
        }
        DataTable tabClient;
        int indexcourant;
        string mode = ""; // ajout ou modif
        DataSet ds;
        SqlDataAdapter adpClient;
        SqlDataAdapter adpEmploye;

        string cnx = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjetFinalBD;Integrated Security=True";

        private void frmClient_Load(object sender, EventArgs e)
        {
            ds = new DataSet();

            // Adapter CLIENTS
            adpClient = new SqlDataAdapter("SELECT * FROM Client", cnx);
            adpClient.Fill(ds, "Client");

            // Adapter EMPLOYES (pour combo Agent)
            adpEmploye = new SqlDataAdapter("SELECT idEmployee, Nom FROM Employees", cnx);
            adpEmploye.Fill(ds, "Employees");

            tabClient = ds.Tables["Client"];
            indexcourant = 0;

            RemplirComboTypeClient();
            RemplirComboAgent();

            AfficherTabDansTextbox();
            MontrerBoutons(true, false);
        }
        private void AfficherTabDansTextbox()
        {
           

            txtNumero.Text = tabClient.Rows[indexcourant]["Numero"].ToString();
            txtNom.Text = tabClient.Rows[indexcourant]["Nom"].ToString();
            txtPrenom.Text = tabClient.Rows[indexcourant]["Prenom"].ToString();
            cboTypeClient.Text = tabClient.Rows[indexcourant]["TypeClient"].ToString();
            cboAgentClient.SelectedValue = tabClient.Rows[indexcourant]["idAgent"];

            lblinfo.Text = "Client " + (indexcourant + 1) +
                           " sur un total de " + tabClient.Rows.Count;
        }
        private void MontrerBoutons(bool btnAjModSup, bool btnSavAn)
        {
            btnAjouter.Visible = btnModifier.Visible = btnSupprimer.Visible = btnAjModSup;
            btnSauvegarder.Visible = btnAnnuler.Visible = btnSavAn;
        }
        private void RemplirComboAgent()
        {
            cboAgentClient.DataSource = ds.Tables["Employees"];
            cboAgentClient.DisplayMember = "Nom";
            cboAgentClient.ValueMember = "IdEmployee";
        }
        private void RemplirComboTypeClient()
        {
            cboTypeClient.Items.Clear();
            cboTypeClient.Items.Add("Acheteur");
            cboTypeClient.Items.Add("Vendeur");
        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {
            mode = "ajout";

            txtNumero.Text = txtNom.Text = txtPrenom.Text = "";
            cboTypeClient.SelectedIndex = -1;
            cboAgentClient.SelectedIndex = -1;

            txtNumero.Focus();
            lblinfo.Text = "En mode ajout d’un nouveau client";

            MontrerBoutons(false, true);
        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            mode = "modif";
            txtNumero.Enabled = false;
            txtNom.Focus();

            lblinfo.Text = "En mode modification du client courant";
            MontrerBoutons(false, true);
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
           if(MessageBox.Show("Supprimer ce client ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tabClient.Rows[indexcourant].Delete();

                SqlCommandBuilder builder = new SqlCommandBuilder(adpClient);
                adpClient.Update(ds, "Clients");

                indexcourant = 0;
                AfficherTabDansTextbox();
            }
        }

        private void btnSauvegarder_Click_1(object sender, EventArgs e)
        {
            string num = txtNumero.Text.Trim();
            string nom = txtNom.Text.Trim();
            string prenom = txtPrenom.Text.Trim();
            string type = cboTypeClient.Text;
            int idEmploye = Convert.ToInt32(cboAgentClient.SelectedValue);

            if (mode == "ajout")
            {
                DataRow row = tabClient.NewRow();
                row["Numero"] = num;
                row["Nom"] = nom;
                row["Prenom"] = prenom;
                row["TypeClient"] = type;
                row["IdEmploye"] = idEmploye;

                tabClient.Rows.Add(row);
                indexcourant = tabClient.Rows.Count - 1;
            }
            else if (mode == "modif")
            {
                DataRow row = tabClient.Rows[indexcourant];
                row["Nom"] = nom;
                row["Prenom"] = prenom;
                row["TypeClient"] = type;
                row["IdEmploye"] = idEmploye;
            }

            SqlCommandBuilder builder = new SqlCommandBuilder(adpClient);
            adpClient.Update(ds, "Clients");

            txtNumero.Enabled = true;
            AfficherTabDansTextbox();
            MontrerBoutons(true, false);
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            txtNumero.Enabled = true;
            AfficherTabDansTextbox();
            MontrerBoutons(true, false);
        }

        private void btnPremier_Click_1(object sender, EventArgs e)
        {
            indexcourant = 0;
            AfficherTabDansTextbox();
        }

        private void btnPrecedent_Click_1(object sender, EventArgs e)
        {

            if (indexcourant > 0)
            {
                indexcourant--;
                AfficherTabDansTextbox();
            }
        }

        private void btnSuivant_Click_1(object sender, EventArgs e)
        {
            if(indexcourant < tabClient.Rows.Count - 1)
            {
                indexcourant++;
                AfficherTabDansTextbox();
            }

        }

        private void btnDernier_Click_1(object sender, EventArgs e)
        {
            indexcourant = tabClient.Rows.Count - 1;
            AfficherTabDansTextbox();

        }
    }
}
