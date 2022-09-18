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
    public partial class Form1 : Form
    {
        BaseDeDonnees maBase;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //événement déclenché lors du chargement du formulaire principal. 
        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            //à partir des champs identifiant et mot de passe, on se connecte sur la base gsb_praticien en local 
            //vous pouvez paramétrer la chaine de connexion ici. 
            //appel du construction de la classe BaseDeDonnees.
            if (textMotDePasse.Text is null)
            {
                textMotDePasse.Text = "";
            }
            maBase = new BaseDeDonnees("localhost", "gsb", "3306", textIdentifiant.Text, textMotDePasse.Text);
            MessageBox.Show("connexion établie");
        }

        private void BtnAfficher_Click(object sender, EventArgs e)
        {
            //on vérifie si le champ text limite de ville n'est pas vide
            if (TextNBVille.Text is not null)
            {
                //convertion sous forme numérique du champ NBVille
                int nbMaxPraticien = Convert.ToInt32(TextNBVille.Text);
                //envois de la requête dans la base de données à l'aide de la classe : MaBase
                //Chargment de la listView
                maBase.chargerVille(listVilles, nbMaxPraticien);
            }
        }

        private void BtnSupp_Click(object sender, EventArgs e)
        {
            if (TextNBVille.Text is not null)
            {
                //envois de la requête dans la base de données à l'aide de la classe : MaBase
                //Chargment de la listView
                int nbVilleMax = Convert.ToInt32(TextNBVille.Text);
                maBase.suppPraticien(listVilles.SelectedItem);
                maBase.chargerVille(listVilles, nbVilleMax);
            }
        }

        private void BntAjout_Click_1(object sender, EventArgs e)
        {
            FrmAjout myForm = new FrmAjout();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
