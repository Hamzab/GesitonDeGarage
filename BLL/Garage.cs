using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Garage
    {

       private List<Automobile> autos;
       private string adresse;

       public string Adresse
       {
           get { return adresse; }
           set { adresse = value; }
       }

       public Garage(string adresse)
       {
           Adresse = adresse;
           autos = new List<Automobile>();
       }
       public string addAuto(Automobile auto)
       {
           try
           {
               autos.Add(auto);
               return "automobile inséré";
           }
           catch (Exception)
           {
               return "erreur l'ajout d'automobile";
           }
           
       }

       public Automobile getAuto(string immatriculation)
       {
          
             foreach(Automobile a in autos) {
                 if (a.Immatriculation == immatriculation)
                 {
                     return a;
                 }
             }  
               return null;
        
       }

       public string deleteAuto(string immatriculation)
       {
           try
           {
               autos.Remove(getAuto(immatriculation));
               return "auto supprimé";
           }
           catch (Exception ex)
           {
               return "erreur de supprission " + ex;
           }
       }

       public int getIndexAuto(Automobile au)
       {
           return autos.IndexOf(au);
       }
       public string updateAuto(Automobile au1,Automobile au2)
       {
           try
           {
               int pos = getIndexAuto(au1);
               autos[pos] = au2;
               return "mise a jour réussi ";
           }
           catch (Exception ex)
           {

               return "mise a jour échoué " + ex;
           }
       }

       public void afficherAutomobile(SubType soustype)
       {
           switch (soustype)
           {
               case SubType.Automobile: foreach (Automobile a in autos)
                   {
                       if (a is Voiture)
                       {
                           Console.WriteLine(a.ToString());
                       }
                   }
                   break;
               case SubType.Moto: foreach (Automobile a in autos)
                   {
                       if (a is Moto)
                       {
                           Console.WriteLine(a.ToString());
                       }
                   }
                   break;

           }
       }

    }
   public enum SubType
   {Automobile,Moto}

}
