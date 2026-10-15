using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinaleFode2025
{
    public partial class frmPrincipale: Form
    {
        public static string RoleUtilisateur;
        public static int IdEmployeConnecte;
        public static bool IsConnected = false;
        public frmPrincipale()
        {
            InitializeComponent();
        }

        private void frmPrincipale_Load(object sender, EventArgs e)
        {

            // AVANT LOGIN : on cache tout sauf Actions
            mnuGestion.Visible = false;
            mnuRechercher.Visible = false;
            mnuQuittez.Visible = false;

            // Actions reste accessible
            mnuActions.Enabled = true;

        }

        private void mnuClients_Click(object sender, EventArgs e)
        {
            frmClient fg = new frmClient();
            fg.MdiParent = this;
            fg.Show();
        }

        private void mnuEmployee_Click(object sender, EventArgs e)
        {
            frmEmployees fg = new frmEmployees();
            fg.MdiParent = this;
            fg.Show();
        }

        private void mnuRechercher_Click(object sender, EventArgs e)
        {
            frmRecherche fg = new frmRecherche();
            fg.MdiParent = this;
            fg.Show();
        }

        private void mnuQuittez_Click(object sender, EventArgs e)
        {
            string msg = "Etes-vous sur de vouloir quitter ce programme ?";
            string tit = "Fermeture de l'application";
            if (MessageBox.Show(msg, tit, MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void munActions_Click(object sender, EventArgs e)
        {
        }
        public void ActiverMenus()
        {

            // Afficher les menus
            mnuGestion.Visible = true;
            mnuRechercher.Visible = true;
            mnuQuittez.Visible = true;

            // Empêcher un nouveau login
            mnuSeConnecter.Enabled = false;
            mnuSeConnecter.Visible = false;

            // Gestion du rôle
            if (RoleUtilisateur == "Agent")
            {
                mnuEmployee.Visible = false;
            }
            else
            {
                mnuEmployee.Visible = true;
            }

        }

        private void mnuSeConnecter_Click(object sender, EventArgs e)
        {
            if (IsConnected)
                return;

            frmLogin f = new frmLogin();
            f.ShowDialog();   // IMPORTANT

            if (IsConnected)
            {
                ActiverMenus();
            }
        }
    }

}
