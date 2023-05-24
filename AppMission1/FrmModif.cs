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
    public partial class FrmModif : Form
    {
        BaseDeDonnees maBase;
        object SelectedItem;
        int id;
        private void FrmAjout_Load(object sender, EventArgs e)
        {
            //événement déclenché lors du chargement du formulaire principal. 
        }

        public FrmModif()
        {
            InitializeComponent();
        }
        private void FrmModif_Load_1(object sender, EventArgs e)
        {
            //maBase.editPraticien(textNom.Text);
            string Liste = SelectedItem.ToString();
            string[] separator = Liste.Split(" | ");
            id = Convert.ToInt32(separator[0]);
            string Nom = separator[1];
            string Prenom = separator[2];
            string Adresse = separator[3];
            double coef = Convert.ToDouble(separator[4]);
            string type = separator[5];
            int id_ville = Convert.ToInt32(separator[6]);
            textNom.Text = Nom.ToString();
            textPrenom.Text = Prenom.ToString();
            textAdresse.Text = Adresse.ToString();
            textCoef.Text = coef.ToString();
            maBase.chargerType(comboBoxCodeType);
            maBase.chargerVilles(comboBoxIdVille);
            comboBoxCodeType.Text = type.ToString();
            comboBoxIdVille.Text = id_ville.ToString();
        }
       /* public FrmModif(BaseDeDonnees maBase)
        {
            InitializeComponent();
            this.maBase = maBase;
        }*/
        public FrmModif(BaseDeDonnees maBase, object Selecteditem)
        {
            InitializeComponent();
            this.maBase = maBase;
            this.SelectedItem = Selecteditem;
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
            //int id = textIdentifiant.Text;
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
            maBase.modifBase(id,nom, prenom, adresse, coef, type, id_ville);
        }
    }
}
