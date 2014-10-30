using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BLL;
using Finisar.SQLite;
namespace GUI
{

  public  class GarageDAO
    {

      
            // We use these three SQLite objects:
             
            SQLiteCommand sqlite_cmd;
            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;New=False;Compress=True;");
            SQLiteDataReader sqlite_datareader;

            // create a new database connection:

        //ajouter voiture
      
      public bool ajouterVoiture(Voiture v)
        {

            try
            {
               
                sqlite_conn.Open();

       
                sqlite_cmd = sqlite_conn.CreateCommand();

        
                
                string req = "Insert Into Automobile(Annee, Immatriculation, Coulour, Marque, TypeV, AutoMoto) Values (" + v.Annee + ", '" + v.Immatriculation + "', '" + v.Coulour + "', '" + v.Marque + "', '" + v.TypeV + "', 'True');";

                 

                // Lets insert something into our new table:
                sqlite_cmd.CommandText = req;

                sqlite_cmd.ExecuteNonQuery();
   
                sqlite_conn.Close();
                return true;
            }
            catch (Exception)
            {
    
                return false;
            }
        }

        //ajouter moto
        public bool ajouterMoto(Moto v)
        {

            try
            {
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                string req = "Insert Into Automobile(Annee, Immatriculation, Cylindre , VitesseMax, AutoMoto) Values (" + v.Annee + ", '" + v.Immatriculation + "', " + v.Cylindre + ", " + v.VitesseMax + ", 'False');";
          
               // Lets insert something into our new table:
                sqlite_cmd.CommandText = req;
                sqlite_cmd.ExecuteNonQuery();
                
                sqlite_conn.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        // afficher tout les voiture

        public List<Voiture> getLseVoitures()
        {
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            List<Voiture> voitures = new List<Voiture>();
            string req = "select * from Automobile where AutoMoto='True';";

            // Lets insert something into our new table:
            sqlite_cmd.CommandText = req;
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Voiture v = new Voiture();
                v.Annee = Int32.Parse(sqlite_datareader["Annee"].ToString());
                v.Immatriculation = sqlite_datareader["Immatriculation"].ToString();
                v.Coulour = sqlite_datareader["Coulour"].ToString();
                v.Marque = sqlite_datareader["Marque"].ToString();
                v.TypeV = sqlite_datareader["TypeV"].ToString();
                voitures.Add(v);
            }
            sqlite_conn.Close();
                return voitures;

        }
        //afficher les motos
        public List<Moto> getLesMotos()
        {
            List<Moto> motos = new List<Moto>();


            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            string req = "select * from Automobile where AutoMoto='False';";

            // Lets insert something into our new table:
            sqlite_cmd.CommandText = req;
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Moto v = new Moto();
                v.Annee = Int32.Parse(sqlite_datareader["Annee"].ToString());
                v.Immatriculation = sqlite_datareader["Immatriculation"].ToString();
                v.Cylindre = Int32.Parse(sqlite_datareader["Cylindre"].ToString());
                v.VitesseMax = Int32.Parse(sqlite_datareader["VitesseMax"].ToString());
           
                motos.Add(v);
            }
            sqlite_conn.Close();
            return motos;

        }

        public Voiture getUneVoiture(string immatriculation)
        {
            Voiture v = new Voiture();

            try
            {
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                string req = "select * from Automobile where Immatriculation='" + immatriculation + "' and AutoMoto='True';";


                sqlite_cmd.CommandText = req;
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    
                    v.Annee = Int32.Parse(sqlite_datareader["Annee"].ToString());
                    v.Immatriculation = sqlite_datareader["Immatriculation"].ToString();
                    v.Coulour = sqlite_datareader["Coulour"].ToString();
                    v.Marque = sqlite_datareader["Marque"].ToString();
                    v.TypeV = sqlite_datareader["TypeV"].ToString();

                }
                sqlite_conn.Close();
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
            try {
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
              string req = "select * from Automobile where Immatriculation='" + immatriculation + "' and AutoMoto='False';";

            // Lets insert something into our new table:
            sqlite_cmd.CommandText = req;
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
             
                m.Annee = Int32.Parse(sqlite_datareader["Annee"].ToString());
                m.Immatriculation = sqlite_datareader["Immatriculation"].ToString();
                m.Cylindre = Int32.Parse(sqlite_datareader["Cylindre"].ToString());
                m.VitesseMax = Int32.Parse(sqlite_datareader["VitesseMax"].ToString());

                
            }
            sqlite_conn.Close();
  }
            catch (Exception)
            {
                Console.WriteLine("Erreur dans la requette");
            }

       
            return m;
        }




        public bool modifierVoiture(string immatriculation, Voiture v)
        {
            try {

                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                string req = "update Automobile set Annee=" + v.Annee + ", Coulour='" + v.Coulour + "', Marque='" + v.Marque + "', TypeV='" + v.TypeV + "'  where Immatriculation='"+immatriculation+"' and AutoMoto='True';";
                sqlite_cmd.CommandText = req;
                sqlite_cmd.ExecuteNonQuery();
                sqlite_conn.Close();
                return false;
            
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool modifierMoto(string immatriculation, Moto m)
        {

            try
            {

                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                string req = "update Automobile set Annee=" + m.Annee + ", Cylindre=" + m.Cylindre + ", VitesseMax=" + m.VitesseMax + "  where Immatriculation='" + immatriculation + "' and AutoMoto='False';";
                sqlite_cmd.CommandText = req;
                sqlite_cmd.ExecuteNonQuery();
                sqlite_conn.Close();
                return false;

            }
            catch (Exception)
            {
                return false;
            } 
            
        }



      // supprission

        public bool supprimerAuto(string immatriculation)
        {
            

          try
            {
          
               sqlite_conn.Open();
       
                sqlite_cmd = sqlite_conn.CreateCommand();
      
                string req = "delete from Automobile where Immatriculation='" + immatriculation + "';";
                sqlite_cmd.CommandText = req;
                sqlite_cmd.ExecuteNonQuery();

                sqlite_conn.Close();
                return true;

            }
      

          catch (Exception)
          {

              Console.WriteLine("matricule n'est pas valide");
              return false;
          }

        }



    }
}
