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

        private void BntRetour_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
