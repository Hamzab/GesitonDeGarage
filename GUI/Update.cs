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
    public partial class Update : Form
    {
        GarageDAO garage = new GarageDAO();
        Voiture vo = new Voiture();
        Moto m = new Moto();
        public Update()
        {
            InitializeComponent();
        }
        private void Update_Load(object sender, EventArgs e)
        {
            combo_categorie.Items.Add("Moto");
            combo_categorie.Items.Add("Voiture");
        }
        private void combo_categorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_categorie.SelectedIndex == 0)
            {
                lbl_colour.Visible = false;
                lbl_marque.Visible = false;
                lbl_typeV.Visible = false;
                lbl_annee_voiture.Visible = false;
                txt_coulour.Visible = false;
                txt_marque.Visible = false;
                txt_typeV.Visible = false;
                txt_annee_voiture.Visible = false;


                lbl_cylindre.Visible = true;
                lbl_vitesse.Visible = true;
                lbl_annee_moto.Visible = true;
                txt_cylindre.Visible = true;
                txt_vitesse.Visible = true;
                txt_annee_moto.Visible = true;

                m = garage.getUnMoto(txt_immatriculation.Text);
                txt_immatriculation.Text = m.Immatriculation;
                txt_annee_moto.Text = m.Annee.ToString();
                txt_cylindre.Text = m.Cylindre.ToString();
                txt_vitesse.Text = m.VitesseMax.ToString();
                
            }
            if (combo_categorie.SelectedIndex == 1)
            {
                lbl_colour.Visible = true;
                lbl_marque.Visible = true;
                lbl_typeV.Visible = true;
                lbl_annee_voiture.Visible = true;

                txt_coulour.Visible = true;
                txt_marque.Visible = true;
                txt_typeV.Visible = true;
                txt_annee_voiture.Visible = true;

                lbl_cylindre.Visible = false;
                lbl_vitesse.Visible = false;
                lbl_annee_moto.Visible = false;
                txt_cylindre.Visible = false;
                txt_vitesse.Visible = false;
                txt_annee_moto.Visible = false;




                
                vo = garage.getUneVoiture(txt_immatriculation.Text);
                txt_immatriculation.Text = vo.Immatriculation;
                txt_annee_voiture.Text = (vo.Annee).ToString();
                txt_typeV.Text = vo.TypeV;
                txt_coulour.Text = vo.Coulour;
                txt_marque.Text = vo.Marque;
                
                
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (combo_categorie.SelectedIndex == 1)
            {

                vo.Annee = Int32.Parse(txt_annee_voiture.Text);
                vo.Immatriculation = txt_immatriculation.Text;
                vo.Coulour = txt_coulour.Text;
                vo.Marque = txt_marque.Text;
                vo.TypeV = txt_typeV.Text;

                txt_annee_voiture.Text="";
                txt_immatriculation.Text="";
                txt_coulour.Text="";
                txt_marque.Text="";
                txt_typeV.Text = "";
                
                garage.modifierVoiture(vo.Immatriculation, vo);
                MessageBox.Show("Modification voiture réussi");
           
            }
            if (combo_categorie.SelectedIndex == 0)
            {
                m.Annee = Int32.Parse(txt_annee_moto.Text);
                m.Immatriculation = txt_immatriculation.Text;
                m.Cylindre = Int32.Parse(txt_cylindre.Text);
                m.VitesseMax = Int32.Parse(txt_vitesse.Text);

                txt_annee_moto.Text="";
                txt_immatriculation.Text="";
                txt_cylindre.Text="";
                txt_vitesse.Text = "";


                garage.modifierMoto(m.Immatriculation, m);
                MessageBox.Show("Modification moto réussi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

 
    }
}
