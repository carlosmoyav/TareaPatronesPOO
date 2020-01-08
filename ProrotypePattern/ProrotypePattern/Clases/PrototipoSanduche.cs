using System;

//Se crea una interfaz de prototipo para poder clonar los prototipos creados
namespace ProrotypePattern.Clases
{
    abstract class PrototipoSanduche
    {
        public abstract PrototipoSanduche Clone();
    }
}
