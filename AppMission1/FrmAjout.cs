using Mission1AP3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMission1
{
    public partial class FrmAjout : Form
    {
        BaseDeDonnees maBase;
        private void FrmAjout_Load(object sender, EventArgs e)
        {
            //événement déclenché lors du chargement du formulaire principal. 
        }

        public FrmAjout()
        {
            InitializeComponent();
        }
        private void FrmAjout_Load_1(object sender, EventArgs e)
        {
            maBase.chargerType(comboBoxCodeType);
            maBase.chargerVilles(comboBoxIdVille);
        }
        public FrmAjout(BaseDeDonnees maBase)
        {
            InitializeComponent();
            this.maBase = maBase;
        }

        private void BntRetour_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1(maBase);
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void BtnValide_Click(object sender, EventArgs e)
        {
            string nom = textNom.Text;
            string prenom = textPrenom.Text;
            string adresse = textAdresse.Text;
            double coef = Convert.ToDouble(textCoef.Text);
            string code_pract = comboBoxCodeType.Text;
            string type = comboBoxCodeType.SelectedItem.ToString();
            string ville = comboBoxIdVille.SelectedItem.ToString();
            string[] separator = type.Split(" | ");
            string[] separator_ville = ville.Split(" | ");
            type = separator[0];
            int id_ville = Convert.ToInt32(separator_ville[0]);
            maBase.ajoutBase(nom, prenom, adresse, coef, type, id_ville);
        }
    }
}
