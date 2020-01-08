using System;
using System.Collections.Generic;
//prototipo concreto aqui se diseñan las carácteristicas del prototipo y se implementa la funcion de clonar
namespace ProrotypePattern.Clases
{
    class Sanduche:PrototipoSanduche
    {
        private string Pan;
        private string Carne;
        private string Queso;
        private string Vegetales;

        public Sanduche(string pan, string carne, string queso, string vegetales)
        {
            Pan = pan;
            Carne = carne;
            Queso = queso;
            Vegetales = vegetales;
        }

        

        public override PrototipoSanduche Clone()
        {
            string listadeingredientes = GetListaDeIngredientes();
            Console.WriteLine("Clonar sanduche con ingredientes: "+ listadeingredientes);

            return MemberwiseClone() as PrototipoSanduche;
        }
        private string GetListaDeIngredientes()
        {
            return (Pan+" "+Carne+" "+Queso+" "+Vegetales); 
        }
    }
    class MenuSanduche
    {
        private Dictionary<string, PrototipoSanduche> _sanduches = new Dictionary<string, PrototipoSanduche>();

        public PrototipoSanduche this [string nombre]
        {
            get { return _sanduches[nombre]; }
            set { _sanduches.Add(nombre, value); }
        }
    }
}
