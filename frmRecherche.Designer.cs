namespace ProjetFinaleFode2025
{
    partial class frmRecherche
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtRefMaison = new System.Windows.Forms.TextBox();
            this.btnRechercherMaison = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRechercheEmployee = new System.Windows.Forms.TextBox();
            this.tnRechercherEmployee = new System.Windows.Forms.Button();
            this.dgvResultat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultat)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "RéferenceMaison:";
            // 
            // txtRefMaison
            // 
            this.txtRefMaison.Location = new System.Drawing.Point(214, 48);
            this.txtRefMaison.Name = "txtRefMaison";
            this.txtRefMaison.Size = new System.Drawing.Size(314, 26);
            this.txtRefMaison.TabIndex = 2;
            this.txtRefMaison.TextChanged += new System.EventHandler(this.txtRefMaison_TextChanged);
            // 
            // btnRechercherMaison
            // 
            this.btnRechercherMaison.Location = new System.Drawing.Point(149, 109);
            this.btnRechercherMaison.Name = "btnRechercherMaison";
            this.btnRechercherMaison.Size = new System.Drawing.Size(237, 33);
            this.btnRechercherMaison.TabIndex = 3;
            this.btnRechercherMaison.Text = "Rechercher";
            this.btnRechercherMaison.UseVisualStyleBackColor = true;
            this.btnRechercherMaison.Click += new System.EventHandler(this.btnRechercherMaison_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "NumeroEmployee:";
            // 
            // txtRechercheEmployee
            // 
            this.txtRechercheEmployee.Location = new System.Drawing.Point(214, 183);
            this.txtRechercheEmployee.Name = "txtRechercheEmployee";
            this.txtRechercheEmployee.Size = new System.Drawing.Size(314, 26);
            this.txtRechercheEmployee.TabIndex = 5;
            // 
            // tnRechercherEmployee
            // 
            this.tnRechercherEmployee.Location = new System.Drawing.Point(149, 252);
            this.tnRechercherEmployee.Name = "tnRechercherEmployee";
            this.tnRechercherEmployee.Size = new System.Drawing.Size(237, 35);
            this.tnRechercherEmployee.TabIndex = 6;
            this.tnRechercherEmployee.Text = "Rechercher";
            this.tnRechercherEmployee.UseVisualStyleBackColor = true;
            this.tnRechercherEmployee.Click += new System.EventHandler(this.tnRechercherEmployee_Click);
            // 
            // dgvResultat
            // 
            this.dgvResultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultat.Location = new System.Drawing.Point(43, 348);
            this.dgvResultat.Name = "dgvResultat";
            this.dgvResultat.RowHeadersWidth = 62;
            this.dgvResultat.RowTemplate.Height = 28;
            this.dgvResultat.Size = new System.Drawing.Size(736, 253);
            this.dgvResultat.TabIndex = 7;
            // 
            // frmRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 620);
            this.Controls.Add(this.dgvResultat);
            this.Controls.Add(this.tnRechercherEmployee);
            this.Controls.Add(this.txtRechercheEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRechercherMaison);
            this.Controls.Add(this.txtRefMaison);
            this.Controls.Add(this.label2);
            this.Name = "frmRecherche";
            this.Text = "frmRecherche";
            this.Load += new System.EventHandler(this.frmRecherche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRefMaison;
        private System.Windows.Forms.Button btnRechercherMaison;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRechercheEmployee;
        private System.Windows.Forms.Button tnRechercherEmployee;
        private System.Windows.Forms.DataGridView dgvResultat;
    }
}