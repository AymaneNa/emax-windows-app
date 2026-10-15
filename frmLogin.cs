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
    public partial class frmLogin: Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string cnx = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjetFinalBD;Integrated Security=True";
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return;
            }

            using (SqlConnection con = new SqlConnection(cnx))
            {
                string sql = "SELECT idEmployee, Type FROM Employees WHERE Username = @user AND Password = @pass";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@user", txtUserName.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // Stocker infos utilisateur
                    frmPrincipale.RoleUtilisateur = dr["Type"].ToString();
                    frmPrincipale.IdEmployeConnecte = Convert.ToInt32(dr["idEmployee"]);
                    frmPrincipale.IsConnected = true;
                    this.Close(); // fermer le login

                }
                else
                {
                    MessageBox.Show("Username ou mot de passe incorrect");
                }
            }
        }
    }
    
}
