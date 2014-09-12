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
//using GUI;
namespace GUI
{
    public partial class Form1 : Form
    {
        GarageDAO garage = new GarageDAO();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

                txt_coulour.Visible = false;
                txt_marque.Visible = false;
                txt_typeV.Visible = false;

                lbl_cylindre.Visible = true;
                lbl_vitesse.Visible = true;
                txt_cylindre.Visible = true;
                txt_vitesse.Visible = true;
            }
            if (combo_categorie.SelectedIndex == 1)
            {
                lbl_colour.Visible = true;
                lbl_marque.Visible = true;
                lbl_typeV.Visible = true;

                txt_coulour.Visible = true;
                txt_marque.Visible = true;
                txt_typeV.Visible = true;

                lbl_cylindre.Visible = false;
                lbl_vitesse.Visible = false;
                txt_cylindre.Visible = false;
                txt_vitesse.Visible = false;
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if (combo_categorie.SelectedIndex == 0)
            {
                Moto m = new Moto();
                m.Annee=Int32.Parse(txt_annee.Text);
                m.Immatriculation=txt_immatriculation.Text;
                m.Cylindre = Int32.Parse(txt_cylindre.Text);
                m.VitesseMax = Int32.Parse(txt_vitesse.Text);
                txt_annee.Text = "";
                txt_immatriculation.Text = "";
                txt_cylindre.Text = "";
                txt_vitesse.Text = "";
                if (garage.ajouterMoto(m))
                {
                    MessageBox.Show("Inssertion réussi");
                }

            }

            if (combo_categorie.SelectedIndex == 1)
            {
                Voiture v = new Voiture();
                v.Annee = Int32.Parse(txt_annee.Text);
                v.Immatriculation = txt_immatriculation.Text;
                v.Coulour = txt_coulour.Text;
                v.Marque = txt_marque.Text;
                v.TypeV = txt_typeV.Text;
                txt_annee.Text = "";
                txt_immatriculation.Text = "";
                txt_coulour.Text = "";
                txt_marque.Text = "";
                txt_typeV.Text = "";
                if (garage.ajouterVoiture(v))
                {
                    MessageBox.Show("Inssertion réussi");
                }

            }
        }

        private void btn_afficher_Click(object sender, EventArgs e)
        {
            Affichage a = new Affichage();
            a.Show();
        }

        private void group_moto_Enter(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //Voiture v = new Voiture();
            //v.Annee = 2015;
            //v.Coulour = "red";
            //v.Marque = "sonata";
            //v.TypeV = "Hunday";
            //if (garage.modifierVoiture("223", v))
            //{
            //    MessageBox.Show("Mise à jour réussi");
            //}  
            Update update = new Update();
            update.Show();
        }


        private void btn_sup_Click(object sender, EventArgs e)
        {
            Supprission sup = new Supprission();
            sup.Show();
        }

 
 
    }
}
