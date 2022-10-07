
namespace AppMission1
{
    partial class FrmModif
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
            this.BntRetour = new System.Windows.Forms.Button();
            this.textNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textAdresse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textCoef = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnValide = new System.Windows.Forms.Button();
            this.comboBoxCodeType = new System.Windows.Forms.ComboBox();
            this.comboBoxIdVille = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BntRetour
            // 
            this.BntRetour.Location = new System.Drawing.Point(338, 380);
            this.BntRetour.Name = "BntRetour";
            this.BntRetour.Size = new System.Drawing.Size(75, 23);
            this.BntRetour.TabIndex = 13;
            this.BntRetour.Text = "Retour";
            this.BntRetour.UseVisualStyleBackColor = true;
            this.BntRetour.Click += new System.EventHandler(this.BntRetour_Click);
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(44, 84);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(112, 23);
            this.textNom.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 20;
            // 
            // textPrenom
            // 
            this.textPrenom.Location = new System.Drawing.Point(179, 84);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(121, 23);
            this.textPrenom.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Prenom";
            // 
            // textAdresse
            // 
            this.textAdresse.Location = new System.Drawing.Point(322, 84);
            this.textAdresse.Name = "textAdresse";
            this.textAdresse.Size = new System.Drawing.Size(140, 23);
            this.textAdresse.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Adresse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nom";
            // 
            // textCoef
            // 
            this.textCoef.Location = new System.Drawing.Point(83, 186);
            this.textCoef.Name = "textCoef";
            this.textCoef.Size = new System.Drawing.Size(113, 23);
            this.textCoef.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Coef Notoriete";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Code Type Practicien";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Id Ville";
            // 
            // BtnValide
            // 
            this.BtnValide.Location = new System.Drawing.Point(338, 320);
            this.BtnValide.Name = "BtnValide";
            this.BtnValide.Size = new System.Drawing.Size(75, 23);
            this.BtnValide.TabIndex = 29;
            this.BtnValide.Text = "Valider";
            this.BtnValide.UseVisualStyleBackColor = true;
            this.BtnValide.Click += new System.EventHandler(this.BtnValide_Click);
            // 
            // comboBoxCodeType
            // 
            this.comboBoxCodeType.FormattingEnabled = true;
            this.comboBoxCodeType.Location = new System.Drawing.Point(214, 186);
            this.comboBoxCodeType.Name = "comboBoxCodeType";
            this.comboBoxCodeType.Size = new System.Drawing.Size(156, 23);
            this.comboBoxCodeType.TabIndex = 32;
            // 
            // comboBoxIdVille
            // 
            this.comboBoxIdVille.FormattingEnabled = true;
            this.comboBoxIdVille.Location = new System.Drawing.Point(388, 186);
            this.comboBoxIdVille.Name = "comboBoxIdVille";
            this.comboBoxIdVille.Size = new System.Drawing.Size(143, 23);
            this.comboBoxIdVille.TabIndex = 33;
            // 
            // FrmModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxIdVille);
            this.Controls.Add(this.comboBoxCodeType);
            this.Controls.Add(this.BtnValide);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textCoef);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textAdresse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPrenom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BntRetour);
            this.Name = "FrmModif";
            this.Text = "FrmModif";
            this.Load += new System.EventHandler(this.FrmModif_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BntRetour;
        private System.Windows.Forms.TextBox textIdentifiant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAdresse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnValide;
        private System.Windows.Forms.TextBox textCoef;
        private System.Windows.Forms.ComboBox comboBoxCodeType;
        private System.Windows.Forms.ComboBox comboBoxIdVille;
    }
}