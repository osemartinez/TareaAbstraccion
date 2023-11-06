using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public class Invertebrado : Animal
    {
        public string Tipo { get; set; }
        public string Clasificacion { get; set; }
        public bool TieneExoesqueleto { get; set; }
        
            

    public Invertebrado(string nombre, int edad, string habitat, bool esDepredador, string tipo, string clasificacion, bool tieneExoesqueleto)
        : base(nombre, edad, habitat, esDepredador)
        {
            Tipo = tipo;
            Clasificacion = clasificacion;
            TieneExoesqueleto = tieneExoesqueleto;
        }

        public override void Comer()
        {
            Console.WriteLine("No está comiendo");
        }

        public override void Moverse()
        {
            Console.WriteLine("Se está moviendo");
        }

        public override void Sonido()
        {
            Console.WriteLine("No emite sonido");
        }
    }

}
