using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class Affichage : Form
    {
        GarageDAO garage = new GarageDAO();
        public Affichage()
        {
            InitializeComponent();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_auto.Items.Clear();
            if (combo_categorie.SelectedIndex == 0)
            {
                list_auto.Items.AddRange(garage.getLesMotos().ToArray());
            }
            if (combo_categorie.SelectedIndex == 1)
            {
               
                list_auto.Items.AddRange(garage.getLseVoitures().ToArray());
            }
     
        }


        private void Affichage_Load(object sender, EventArgs e)
        {
            combo_categorie.Items.Add("Moto");
            combo_categorie.Items.Add("Voiture");
        }

    

        private void list_auto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Automobile au = list_auto.SelectedItem as Automobile;
            if (combo_categorie.SelectedIndex == 1)
            {
                txt_annee.Text = "";
                txt_immatriculation.Text = "";
                txt_cylindre.Text = "";
                txt_vitesse.Text = "";
                
                Voiture v = au as Voiture;
                if(v!= null)
                {
                    txt_annee.Text = v.Annee.ToString();
                    txt_immatriculation.Text = v.Immatriculation.ToString();
                    txt_marque.Text = v.Marque.ToString();
                    txt_coulour.Text = v.Coulour.ToString();
                    txt_typeV.Text = v.TypeV.ToString();
                }
          

            }
            if (combo_categorie.SelectedIndex == 0)
            {
                txt_annee.Text = "";
                txt_immatriculation.Text = "";
                txt_marque.Text= "";
                txt_coulour.Text= "";
                txt_typeV.Text = "";



                Moto m = au as Moto;
                if (m != null)
                {

                    txt_annee.Text = m.Annee.ToString();
                    txt_immatriculation.Text = m.Immatriculation.ToString();
                    txt_cylindre.Text = m.Cylindre.ToString();
                    txt_vitesse.Text = m.VitesseMax.ToString();

                }
  
            }
        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
