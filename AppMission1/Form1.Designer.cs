
namespace AppMission1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConnexion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textIdentifiant = new System.Windows.Forms.TextBox();
            this.textMotDePasse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextNBVille = new System.Windows.Forms.TextBox();
            this.BtnAfficher = new System.Windows.Forms.Button();
            this.listVilles = new System.Windows.Forms.ListBox();
            this.BtnSupp = new System.Windows.Forms.Button();
            this.BntAjout = new System.Windows.Forms.Button();
            this.BntModif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des Medecins";
            // 
            // BtnConnexion
            // 
            this.BtnConnexion.Location = new System.Drawing.Point(628, 205);
            this.BtnConnexion.Name = "BtnConnexion";
            this.BtnConnexion.Size = new System.Drawing.Size(75, 23);
            this.BtnConnexion.TabIndex = 2;
            this.BtnConnexion.Text = "Connexion";
            this.BtnConnexion.UseVisualStyleBackColor = true;
            this.BtnConnexion.Click += new System.EventHandler(this.BtnConnexion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Identifiant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(688, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mot de Passe";
            // 
            // textIdentifiant
            // 
            this.textIdentifiant.Location = new System.Drawing.Point(540, 154);
            this.textIdentifiant.Name = "textIdentifiant";
            this.textIdentifiant.Size = new System.Drawing.Size(100, 23);
            this.textIdentifiant.TabIndex = 5;
            // 
            // textMotDePasse
            // 
            this.textMotDePasse.Location = new System.Drawing.Point(688, 154);
            this.textMotDePasse.Name = "textMotDePasse";
            this.textMotDePasse.Size = new System.Drawing.Size(100, 23);
            this.textMotDePasse.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Limite de Villes à Afficher";
            // 
            // TextNBVille
            // 
            this.TextNBVille.Location = new System.Drawing.Point(540, 303);
            this.TextNBVille.Name = "TextNBVille";
            this.TextNBVille.Size = new System.Drawing.Size(100, 23);
            this.TextNBVille.TabIndex = 8;
            this.TextNBVille.Text = "50";
            // 
            // BtnAfficher
            // 
            this.BtnAfficher.Location = new System.Drawing.Point(628, 353);
            this.BtnAfficher.Name = "BtnAfficher";
            this.BtnAfficher.Size = new System.Drawing.Size(75, 23);
            this.BtnAfficher.TabIndex = 9;
            this.BtnAfficher.Text = "Afficher";
            this.BtnAfficher.UseVisualStyleBackColor = true;
            this.BtnAfficher.Click += new System.EventHandler(this.BtnAfficher_Click);
            // 
            // listVilles
            // 
            this.listVilles.FormattingEnabled = true;
            this.listVilles.ItemHeight = 15;
            this.listVilles.Location = new System.Drawing.Point(13, 45);
            this.listVilles.Name = "listVilles";
            this.listVilles.Size = new System.Drawing.Size(500, 349);
            this.listVilles.TabIndex = 10;
            // 
            // BtnSupp
            // 
            this.BtnSupp.Location = new System.Drawing.Point(629, 395);
            this.BtnSupp.Name = "BtnSupp";
            this.BtnSupp.Size = new System.Drawing.Size(75, 23);
            this.BtnSupp.TabIndex = 11;
            this.BtnSupp.Text = "Supprimer";
            this.BtnSupp.UseVisualStyleBackColor = true;
            this.BtnSupp.Click += new System.EventHandler(this.BtnSupp_Click);
            // 
            // BntAjout
            // 
            this.BntAjout.Location = new System.Drawing.Point(526, 371);
            this.BntAjout.Name = "BntAjout";
            this.BntAjout.Size = new System.Drawing.Size(75, 23);
            this.BntAjout.TabIndex = 12;
            this.BntAjout.Text = "Ajouter";
            this.BntAjout.UseVisualStyleBackColor = true;
            this.BntAjout.Click += new System.EventHandler(this.BntAjout_Click_1);
            // 
            // BntModif
            // 
            this.BntModif.Location = new System.Drawing.Point(713, 371);
            this.BntModif.Name = "BntModif";
            this.BntModif.Size = new System.Drawing.Size(75, 23);
            this.BntModif.TabIndex = 13;
            this.BntModif.Text = "Modifier";
            this.BntModif.UseVisualStyleBackColor = true;
            this.BntModif.Click += new System.EventHandler(this.BntModif_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BntModif);
            this.Controls.Add(this.BntAjout);
            this.Controls.Add(this.BtnSupp);
            this.Controls.Add(this.listVilles);
            this.Controls.Add(this.BtnAfficher);
            this.Controls.Add(this.TextNBVille);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textMotDePasse);
            this.Controls.Add(this.textIdentifiant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnConnexion);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Liste Des Medecins";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConnexion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textIdentifiant;
        private System.Windows.Forms.TextBox textMotDePasse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextNBVille;
        private System.Windows.Forms.Button BtnAfficher;
        private System.Windows.Forms.ListBox listVilles;
        private System.Windows.Forms.Button BtnSupp;
        private System.Windows.Forms.Button BntAjout;
        private System.Windows.Forms.Button BntModif;
    }
}

