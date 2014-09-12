using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BLL;

namespace GUI
{
  public  class GarageDAO
    {
        //ajouter voiture
        public bool ajouterVoiture(Voiture v)
        {

            string connexionString = @"Data source=hamza-pc;Initial catalog=GarageHamza; Trusted_Connection=True;";
            SqlConnection cnx = new SqlConnection(connexionString);
            
            try
            {
               
                cnx.Open();
                
                string req = "Insert Into Automobile(Annee, Immatriculation, Coulour, Marque, TypeV, AutoMoto) Values (" + v.Annee + ", '" + v.Immatriculation + "', '" + v.Coulour + "', '" + v.Marque + "', '" + v.TypeV + "', 'True');";
                
                SqlCommand cmd = new SqlCommand(req, cnx);
                
                if (cmd.ExecuteNonQuery() > 0)
                {
                    cnx.Close();
                    return true;
                }
                else
                {
                    
                    cnx.Close();
                    return false;
                }
            }
            catch (Exception)
            {
    
                return false;
            }
        }

        //ajouter moto
        public bool ajouterMoto(Moto v)
        {
            string connexionString = @"Data source=hamza-pc;Initial catalog=GarageHamza; Trusted_Connection=True;";
            SqlConnection cnx = new SqlConnection(connexionString);
            try
            {
                cnx.Open();
                string req = "Insert Into Automobile(Annee,Immatriculation, Cylindre, VitesseMax, AutoMoto) Values (" + v.Annee + ", '" + v.Immatriculation + "'," + v.Cylindre + "," + v.VitesseMax + ", 'False');";
                SqlCommand cmd = new SqlCommand(req, cnx);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    cnx.Close();
                    return true;
                }
                else
                {
                    cnx.Close();
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        // afficher tout les voiture

        public List<Voiture> getLseVoitures()
        {
            List<Voiture> voitures = new List<Voiture>();
            string connexionString = @"Data source=hamza-pc;Initial catalog=GarageHamza; Trusted_Connection=True;";
            SqlConnection cnx = new SqlConnection(connexionString);
                cnx.Open();
                string req = "select * from Automobile where AutoMoto='True';";
                SqlCommand cmd = new SqlCommand(req, cnx);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Voiture v = new Voiture();
                    v.Annee = Int32.Parse(reader["Annee"].ToString());
                    v.Immatriculation=reader["Immatriculation"].ToString();
                    v.Coulour=reader["Coulour"].ToString();
                    v.Marque = reader["Marque"].ToString();
                    v.TypeV = reader["TypeV"].ToString();
                    voitures.Add(v);
                }
                cnx.Close();
                return voitures;

        }
        //afficher les motos
        public List<Moto> getLesMotos()
        {
            List<Moto> motos = new List<Moto>();
            string connexionString = @"Data source=hamza-pc;Initial catalog=GarageHamza; Trusted_Connection=True;";
            SqlConnection cnx = new SqlConnection(connexionString);
            cnx.Open();
            string req = "select * from Automobile where AutoMoto='False';";
            SqlCommand cmd = new SqlCommand(req, cnx);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Moto v = new Moto();
                v.Annee = Int32.Parse(reader["Annee"].ToString());
                v.Immatriculation = reader["Immatriculation"].ToString();
                v.Cylindre = Int32.Parse(reader["Cylindre"].ToString());
                v.VitesseMax = Int32.Parse(reader["VitesseMax"].ToString());

                motos.Add(v);
            }
            cnx.Close();
            return motos;

        }

        public Voiture getUneVoiture(string immatriculation)
        {
            Voiture v = new Voiture();
            string connexionString = @"Data source=hamza-pc;Initial catalog=GarageHamza; Trusted_Connection=True;";
            SqlConnection cnx = new SqlConnection(connexionString);
            try { 
            cnx.Open();
            string req = "select * from Automobile where Immatriculation='" + immatriculation + "' and AutoMoto='True';";
            SqlCommand cmd = new SqlCommand(req, cnx);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                v.Annee = Int32.Parse(reader["Annee"].ToString());
                v.Immatriculation = reader["Immatriculation"].ToString();
                v.Coulour = reader["Coulour"].ToString();
                v.Marque = reader["Marque"].ToString();
                v.TypeV = reader["TypeV"].ToString();

            }
            cnx.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Erreur dans la requette");
            }
            return v;
        }


        public Moto getUnMoto(string immatriculation)
        {
            Moto m = new Moto();
            string connexionString = @"Data source=hamza-pc;Initial catalog=GarageHamza; Trusted_Connection=True;";
            SqlConnection cnx = new SqlConnection(connexionString);
            try
            {
                cnx.Open();
                string req = "select * from Automobile where Immatriculation='" + immatriculation + "' and AutoMoto='False';";
                SqlCommand cmd = new SqlCommand(req, cnx);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    m.Annee = Int32.Parse(reader["Annee"].ToString());
                    m.Immatriculation = reader["Immatriculation"].ToString();
                    m.Cylindre = Int32.Parse(reader["Cylindre"].ToString());
                    m.VitesseMax = Int32.Parse(reader["VitesseMax"].ToString());
                   

                }
                cnx.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Erreur dans la requette");
            }
            return m;
        }




        public bool modifierVoiture(string immatriculation, Voiture v)
        {
            List<Voiture> voitures = new List<Voiture>();
            string connexionString = @"Data source=hamza-pc;Initial catalog=GarageHamza; Trusted_Connection=True;";
            SqlConnection cnx = new SqlConnection(connexionString);
            try { 
            cnx.Open();
            string req = "update Automobile set Annee=" + v.Annee + ", Coulour='" + v.Coulour + "', Marque='" + v.Marque + "', TypeV='" + v.TypeV + "'  where Immatriculation='"+immatriculation+"' and AutoMoto='True';";
            SqlCommand cmd = new SqlCommand(req, cnx);
            if (cmd.ExecuteNonQuery() > 0)
            {
                cnx.Close();
                return true;
            }
            else
            {
                cnx.Close();
                return false;
            }
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool modifierMoto(string immatriculation, Moto m)
        {
            List<Voiture> voitures = new List<Voiture>();
            string connexionString = @"Data source=hamza-pc;Initial catalog=GarageHamza; Trusted_Connection=True;";
            SqlConnection cnx = new SqlConnection(connexionString);
            try
            {
                cnx.Open();
                string req = "update Automobile set Annee=" + m.Annee + ", Cylindre=" + m.Cylindre + ", VitesseMax=" + m.VitesseMax + "  where Immatriculation='" + immatriculation + "' and AutoMoto='False';";
                SqlCommand cmd = new SqlCommand(req, cnx);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    cnx.Close();
                    return true;
                }
                else
                {
                    cnx.Close();
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }



      // supprission

        public bool supprimerAuto(string immatriculation)
        {
            Voiture v = new Voiture();
            string connexionString = @"Data source=hamza-pc;Initial catalog=GarageHamza; Trusted_Connection=True;";
            SqlConnection cnx = new SqlConnection(connexionString);
            try
            {
                cnx.Open();
                
                string req = "delete from Automobile where Immatriculation='" + immatriculation + "';";
                SqlCommand cmd = new SqlCommand(req, cnx);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("bbbbbbbbbbb"); 
                    cnx.Close();
                    return true;
                }
                else
                {
                    cnx.Close();
                    return false;
                }
       
            }
            catch (Exception)
            {

                Console.WriteLine("matricule n'est pas valide");
                return false;
            }
           
        }



    }
}
