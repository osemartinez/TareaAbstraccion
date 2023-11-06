using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    using System;

    public abstract class Animal
    {
        // Los 4 atributos
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Habitat {  get; set; }
    public bool EsDepredador { get; set; }

        // Los 3 métodos abstractos
        public abstract void Comer();
        public abstract void Moverse();
        public abstract void Sonido();

        // Constructor
        public Animal(string nombre, int edad, string habitat, bool esDepredador)
        {
            Nombre = nombre;
            Edad = edad;
            Habitat = habitat;
            EsDepredador = esDepredador;
        }
    }

    

}
