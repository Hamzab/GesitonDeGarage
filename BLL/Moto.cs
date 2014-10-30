using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Moto:Automobile
    {
       private int cylindre;
       private int vitesseMax;

       public int Cylindre
       {
           get { return cylindre; }
           set { cylindre = value; }
       }

       public int VitesseMax
       {
           get { return vitesseMax; }
           set { vitesseMax = value; }
       }
       public Moto()
       {

       }
       public Moto(int annee, string immatriculation, int cylindre, int vitesseMax)
           : base(annee, immatriculation)
       {
           Cylindre = cylindre;
           VitesseMax = vitesseMax;
       }

       public override string ToString()
       {
           return base.ToString() +" "+ Cylindre;
            
       }
      

    }
}
