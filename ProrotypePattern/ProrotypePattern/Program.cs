using System;
using System.Collections.Generic;
using ProrotypePattern.Clases;

namespace ProrotypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuSanduche menuSanduche = new MenuSanduche();

            menuSanduche["Americano"] = new Sanduche("Queso", "Tocino", "Huevo", "");
            menuSanduche["Ecuatoriano"] = new Sanduche("Queso", "Jamón", "Tomate", "Lechuga");


            menuSanduche["Combo Americano"]= new Sanduche("Queso", "Tocino, Huevo", "papas fritas", "Cola");
            menuSanduche["Combo Bajo en grasa"] = new Sanduche("Pollo", "lechuga, tomate", "pepinillos", "Agua");
            //aqui se aplica el cliente, el cual crea un nuevo objeto a partir de clonar uno
            //de una lista de prototipos
            Sanduche sanduche1 = menuSanduche["Americano"].Clone() as Sanduche;
            Sanduche sanduche2 = menuSanduche["Combo Americano"].Clone() as Sanduche;
            Sanduche sanduche3 = menuSanduche["Combo Bajo en grasa"].Clone() as Sanduche;


        }
    }
}
