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
    public partial class frmRecherche: Form
    {
        string cnx = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjetFinalBD;Integrated Security=True";

        DataSet ds;
        SqlDataAdapter adp;
        public frmRecherche()
        {
            InitializeComponent();
        }

        private void frmRecherche_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
        }

        private void btnRechercherMaison_Click(object sender, EventArgs e)
        {

            if (txtRefMaison.Text.Trim() == "")
            {
                MessageBox.Show("Veuillez entrer une référence de maison");
                return;
            }

            ds.Clear();

            string sql = @"SELECT M.Numero, M.Reference, M.Adresse, M.Prix,
                          E.Nom AS Agent, C.Nom AS Vendeur
                   FROM Maison M
                   INNER JOIN Employees E ON M.idEmployee = E.idEmployee
                   INNER JOIN Client C ON M.idClient = C.idClient
                   WHERE M.Reference = @ref";

            adp = new SqlDataAdapter(sql, cnx);
            adp.SelectCommand.Parameters.AddWithValue("@ref", txtRefMaison.Text.Trim());

            adp.Fill(ds, "ResultatMaison");

            dgvResultat.DataSource = ds.Tables["ResultatMaison"];
        }


        private void txtRefMaison_TextChanged(object sender, EventArgs e)
        {

        }

        private void tnRechercherEmployee_Click(object sender, EventArgs e)
        {
            if (txtRechercheEmployee.Text.Trim() == "")
            {
                MessageBox.Show("Veuillez entrer un numéro d’employé");
                return;
            }

            ds.Clear();

            string sql = @"SELECT Numero, Nom, Prenom, Type, Salaire
                   FROM Employees
                   WHERE Numero = @num";

            adp = new SqlDataAdapter(sql, cnx);
            adp.SelectCommand.Parameters.AddWithValue("@num", txtRechercheEmployee.Text.Trim());

            adp.Fill(ds, "ResultatEmploye");

            dgvResultat.DataSource = ds.Tables["ResultatEmploye"];
        }
    }
    
}
