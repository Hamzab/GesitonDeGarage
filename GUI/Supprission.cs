using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Supprission : Form
    {
        GarageDAO garage = new GarageDAO();
        public Supprission()
        {
            InitializeComponent();
        }

        private void btn_sup_Click(object sender, EventArgs e)
        {
            if (garage.supprimerAuto(txt_matricule.Text))
            {
                txt_matricule.Text = "";
                MessageBox.Show("Supprission automobile réussi");
            }
            else
            {
                txt_matricule.Text = "";
                MessageBox.Show("Supprission automobile échoué");
            }
           
        }

        private void Supprission_Load(object sender, EventArgs e)
        {

        }

        private void txt_matricule_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_supp_Click(object sender, EventArgs e)
        {

        }
    }
}
