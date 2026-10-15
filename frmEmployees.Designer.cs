namespace ProjetFinaleFode2025
{
    partial class frmEmployees
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrenomEmployee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTypeEmployee = new System.Windows.Forms.ComboBox();
            this.lblinfo = new System.Windows.Forms.Label();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnPremier = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnSauvgarder = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtNomEmployee = new System.Windows.Forms.TextBox();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.txtNumEmployee = new System.Windows.Forms.TextBox();
            this.txtSalaire = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.txtPrenomEmployee);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboTypeEmployee);
            this.groupBox1.Controls.Add(this.lblinfo);
            this.groupBox1.Controls.Add(this.btnDernier);
            this.groupBox1.Controls.Add(this.btnSuivant);
            this.groupBox1.Controls.Add(this.btnPrecedent);
            this.groupBox1.Controls.Add(this.btnPremier);
            this.groupBox1.Controls.Add(this.btnModifier);
            this.groupBox1.Controls.Add(this.btnSupprimer);
            this.groupBox1.Controls.Add(this.btnSauvgarder);
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Controls.Add(this.txtNomEmployee);
            this.groupBox1.Controls.Add(this.txtSal);
            this.groupBox1.Controls.Add(this.txtNumEmployee);
            this.groupBox1.Controls.Add(this.txtSalaire);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(52, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 354);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion des Employees";
            // 
            // txtPrenomEmployee
            // 
            this.txtPrenomEmployee.Location = new System.Drawing.Point(128, 121);
            this.txtPrenomEmployee.Name = "txtPrenomEmployee";
            this.txtPrenomEmployee.Size = new System.Drawing.Size(339, 26);
            this.txtPrenomEmployee.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Prenom:";
            // 
            // cboTypeEmployee
            // 
            this.cboTypeEmployee.FormattingEnabled = true;
            this.cboTypeEmployee.Location = new System.Drawing.Point(128, 160);
            this.cboTypeEmployee.Name = "cboTypeEmployee";
            this.cboTypeEmployee.Size = new System.Drawing.Size(339, 28);
            this.cboTypeEmployee.TabIndex = 42;
            // 
            // lblinfo
            // 
            this.lblinfo.BackColor = System.Drawing.Color.White;
            this.lblinfo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblinfo.Location = new System.Drawing.Point(55, 301);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(561, 39);
            this.lblinfo.TabIndex = 41;
            this.lblinfo.Text = "label6";
            this.lblinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(536, 252);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(141, 32);
            this.btnDernier.TabIndex = 40;
            this.btnDernier.Text = "Dernier";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(367, 252);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(141, 32);
            this.btnSuivant.TabIndex = 39;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(197, 252);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(141, 32);
            this.btnPrecedent.TabIndex = 38;
            this.btnPrecedent.Text = "Precedent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(34, 252);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(141, 32);
            this.btnPremier.TabIndex = 37;
            this.btnPremier.Text = "Premier";
            this.btnPremier.UseVisualStyleBackColor = true;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(524, 75);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(164, 31);
            this.btnModifier.TabIndex = 36;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(524, 116);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(164, 31);
            this.btnSupprimer.TabIndex = 35;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnSauvgarder
            // 
            this.btnSauvgarder.Location = new System.Drawing.Point(524, 163);
            this.btnSauvgarder.Name = "btnSauvgarder";
            this.btnSauvgarder.Size = new System.Drawing.Size(164, 31);
            this.btnSauvgarder.TabIndex = 34;
            this.btnSauvgarder.Text = "Sauvegarder";
            this.btnSauvgarder.UseVisualStyleBackColor = true;
            this.btnSauvgarder.Click += new System.EventHandler(this.btnSauvgarder_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(524, 202);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(164, 31);
            this.btnAnnuler.TabIndex = 33;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(524, 30);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(164, 31);
            this.btnAjouter.TabIndex = 32;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtNomEmployee
            // 
            this.txtNomEmployee.Location = new System.Drawing.Point(128, 80);
            this.txtNomEmployee.Name = "txtNomEmployee";
            this.txtNomEmployee.Size = new System.Drawing.Size(339, 26);
            this.txtNomEmployee.TabIndex = 31;
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(128, 196);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(339, 26);
            this.txtSal.TabIndex = 30;
            // 
            // txtNumEmployee
            // 
            this.txtNumEmployee.Location = new System.Drawing.Point(128, 36);
            this.txtNumEmployee.Name = "txtNumEmployee";
            this.txtNumEmployee.Size = new System.Drawing.Size(339, 26);
            this.txtNumEmployee.TabIndex = 28;
            // 
            // txtSalaire
            // 
            this.txtSalaire.AutoSize = true;
            this.txtSalaire.Location = new System.Drawing.Point(18, 202);
            this.txtSalaire.Name = "txtSalaire";
            this.txtSalaire.Size = new System.Drawing.Size(62, 20);
            this.txtSalaire.TabIndex = 27;
            this.txtSalaire.Text = "Salaire:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nom:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Numero:";
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEmployees";
            this.Text = "frmEmployees";
            this.Load += new System.EventHandler(this.frmEmployees_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrenomEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTypeEmployee;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnSauvgarder;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtNomEmployee;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.TextBox txtNumEmployee;
        private System.Windows.Forms.Label txtSalaire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}