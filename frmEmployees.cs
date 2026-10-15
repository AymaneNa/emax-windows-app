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
    public partial class frmEmployees: Form
    {
        DataSet ds;
        SqlDataAdapter adpEmploye;
        DataTable tabEmploye;

        int indexcourant;
        string mode = ""; // ajout ou modif

        string cnx = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjetFinalBD;Integrated Security=True";
        public frmEmployees()
        {
            InitializeComponent();
        }
        private void frmEmployees_Load(object sender, EventArgs e)
        {
            ds = new DataSet();

            adpEmploye = new SqlDataAdapter("SELECT * FROM Employees", cnx);
            adpEmploye.Fill(ds, "Employees");

            tabEmploye = ds.Tables["Employees"];
            indexcourant = 0;

            RemplirComboTypeEmployee();
            AfficherTabDansTextbox();
            MontrerBoutons(true, false);
        }
        private void AfficherTabDansTextbox()
        {
            if (tabEmploye == null || tabEmploye.Rows.Count == 0)
            {
                lblinfo.Text = "Aucun employé trouvé";
                return;
            }

            txtNumEmployee.Text = tabEmploye.Rows[indexcourant]["Numero"].ToString();
            txtNomEmployee.Text = tabEmploye.Rows[indexcourant]["Nom"].ToString();
            txtPrenomEmployee.Text = tabEmploye.Rows[indexcourant]["Prenom"].ToString();
            cboTypeEmployee.Text = tabEmploye.Rows[indexcourant]["Type"].ToString();
            txtSal.Text = tabEmploye.Rows[indexcourant]["Salaire"].ToString();

            lblinfo.Text = "Employé " + (indexcourant + 1) +
                           " sur un total de " + tabEmploye.Rows.Count;
        }
        private void MontrerBoutons(bool btnAjModSup, bool btnSavAn)
        {
            btnAjouter.Visible = btnModifier.Visible = btnSupprimer.Visible = btnAjModSup;
            btnSauvgarder.Visible = btnAnnuler.Visible = btnSavAn;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            mode = "ajout";

            txtNumEmployee.Text = txtNomEmployee.Text =
            txtPrenomEmployee.Text = txtSal.Text = "";

            cboTypeEmployee.SelectedIndex = -1;

            txtNumEmployee.Focus();
            lblinfo.Text = "En mode ajout d’un nouvel employé";

            MontrerBoutons(false, true);

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            mode = "modif";
            txtNumEmployee.Enabled = false;

            txtNomEmployee.Focus();
            lblinfo.Text = "En mode modification de l’employé courant";

            MontrerBoutons(false, true);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Supprimer cet employé ?", "Confirmation",
       MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tabEmploye.Rows[indexcourant].Delete();

                SqlCommandBuilder builder = new SqlCommandBuilder(adpEmploye);
                adpEmploye.Update(ds, "Employes");

                indexcourant = 0;
                AfficherTabDansTextbox();

            }
        }

        private void btnSauvgarder_Click(object sender, EventArgs e)
        {
            string num = txtNumEmployee.Text.Trim();
            string nom = txtNomEmployee.Text.Trim();
            string prenom = txtPrenomEmployee.Text.Trim();
            string type = cboTypeEmployee.Text;
            double salaire = Convert.ToDouble(txtSal.Text);

            if (mode == "ajout")
            {
                DataRow row = tabEmploye.NewRow();
                row["Numero"] = num;
                row["Nom"] = nom;
                row["Prenom"] = prenom;
                row["Type"] = type;
                row["Salaire"] = salaire;

                tabEmploye.Rows.Add(row);
                indexcourant = tabEmploye.Rows.Count - 1;
            }
            else if (mode == "modif")
            {
                DataRow row = tabEmploye.Rows[indexcourant];
                row["Nom"] = nom;
                row["Prenom"] = prenom;
                row["Type"] = type;
                row["Salaire"] = salaire;
            }

            SqlCommandBuilder builder = new SqlCommandBuilder(adpEmploye);
            adpEmploye.Update(ds, "Employes");

            txtNumEmployee.Enabled = true;
            AfficherTabDansTextbox();
            MontrerBoutons(true, false);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtNumEmployee.Enabled = true;
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
            if (indexcourant < tabEmploye.Rows.Count - 1)
            {
                indexcourant++;
                AfficherTabDansTextbox();
            }
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {

            indexcourant = tabEmploye.Rows.Count - 1; ;
            AfficherTabDansTextbox();

        }
        private void RemplirComboTypeEmployee()
        {
            cboTypeEmployee.Items.Clear();
            cboTypeEmployee.Items.Add("Admin");
            cboTypeEmployee.Items.Add("Agent");
        }


    }
}
