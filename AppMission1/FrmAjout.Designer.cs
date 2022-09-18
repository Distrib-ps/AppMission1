
namespace AppMission1
{
    partial class FrmAjout
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
            this.textIdentifiant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            // textIdentifiant
            // 
            this.textIdentifiant.Location = new System.Drawing.Point(350, 223);
            this.textIdentifiant.Name = "textIdentifiant";
            this.textIdentifiant.Size = new System.Drawing.Size(100, 23);
            this.textIdentifiant.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Identifiant";
            // 
            // FrmAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textIdentifiant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BntRetour);
            this.Name = "FrmAjout";
            this.Text = "FrmAjout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BntRetour;
        private System.Windows.Forms.TextBox textIdentifiant;
        private System.Windows.Forms.Label label2;
    }
}