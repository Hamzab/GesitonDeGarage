using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Automobile
    {
        private int annee;
        private string immatriculation;
        
        public int Annee
        {
            get { return annee;}
            set {annee = value;}
        }

        public string Immatriculation
        {
            get { return immatriculation; }
            set { immatriculation = value; }
        }

        public Automobile()
        {

        }

        public Automobile(int ann, string imm)
        {
            Annee = ann;
            Immatriculation = imm;
        }
        public override string ToString()
        {
            return "immatriculation "+this.Immatriculation +" annee "+this.Annee;
        }

        public void afficher()
        {
            Console.WriteLine(ToString());
        }
    }
}
