using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Voiture:Automobile
    {
        private string coulour;
        private string marque;
        private string typeV;

        public string Coulour
        {
            get { return coulour; }
            set { coulour = value; }
        }
        public string Marque
        {
            get { return marque; }
            set { marque = value; }
        }
        public string TypeV
        {
            get { return typeV; }
            set { typeV = value; }
        }

        public Voiture(int annee, string immatriculation,string coulour, string marque, string typeV): base(annee,immatriculation)
        {
            Coulour = coulour;
            Marque = marque;
            TypeV = typeV;
        }
        public Voiture()
        {

        }
        public override string ToString()
        {
            return base.ToString() +" "+ marque;
             
        }


    }
}
