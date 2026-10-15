namespace ProjetFinaleFode2025
{
    partial class frmPrincipale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnuActions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClients = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRechercher = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuittez = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeConnecter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuActions});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 33);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mnuActions
            // 
            this.mnuActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGestion,
            this.mnuRechercher,
            this.mnuQuittez,
            this.mnuSeConnecter});
            this.mnuActions.Name = "mnuActions";
            this.mnuActions.Size = new System.Drawing.Size(87, 29);
            this.mnuActions.Text = "Actions";
            this.mnuActions.Click += new System.EventHandler(this.munActions_Click);
            // 
            // mnuGestion
            // 
            this.mnuGestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClients,
            this.mnuEmployee});
            this.mnuGestion.Name = "mnuGestion";
            this.mnuGestion.Size = new System.Drawing.Size(270, 34);
            this.mnuGestion.Text = "Gestion";
            // 
            // mnuClients
            // 
            this.mnuClients.Name = "mnuClients";
            this.mnuClients.Size = new System.Drawing.Size(270, 34);
            this.mnuClients.Text = "Clients";
            this.mnuClients.Click += new System.EventHandler(this.mnuClients_Click);
            // 
            // mnuEmployee
            // 
            this.mnuEmployee.Name = "mnuEmployee";
            this.mnuEmployee.Size = new System.Drawing.Size(270, 34);
            this.mnuEmployee.Text = "Employees";
            this.mnuEmployee.Click += new System.EventHandler(this.mnuEmployee_Click);
            // 
            // mnuRechercher
            // 
            this.mnuRechercher.Name = "mnuRechercher";
            this.mnuRechercher.Size = new System.Drawing.Size(270, 34);
            this.mnuRechercher.Text = "Rechercher";
            this.mnuRechercher.Click += new System.EventHandler(this.mnuRechercher_Click);
            // 
            // mnuQuittez
            // 
            this.mnuQuittez.Name = "mnuQuittez";
            this.mnuQuittez.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuQuittez.Size = new System.Drawing.Size(270, 34);
            this.mnuQuittez.Text = "Quittez  ";
            this.mnuQuittez.Click += new System.EventHandler(this.mnuQuittez_Click);
            // 
            // mnuSeConnecter
            // 
            this.mnuSeConnecter.Name = "mnuSeConnecter";
            this.mnuSeConnecter.Size = new System.Drawing.Size(270, 34);
            this.mnuSeConnecter.Text = "Se Connecter";
            this.mnuSeConnecter.Click += new System.EventHandler(this.mnuSeConnecter_Click);
            // 
            // frmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetFinaleFode2025.Properties.Resources.imageremax;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipale";
            this.Text = "frmPrincipale";
            this.Load += new System.EventHandler(this.frmPrincipale_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnuActions;
        private System.Windows.Forms.ToolStripMenuItem mnuGestion;
        private System.Windows.Forms.ToolStripMenuItem mnuRechercher;
        private System.Windows.Forms.ToolStripMenuItem mnuQuittez;
        private System.Windows.Forms.ToolStripMenuItem mnuClients;
        private System.Windows.Forms.ToolStripMenuItem mnuEmployee;
        private System.Windows.Forms.ToolStripMenuItem mnuSeConnecter;
    }
}