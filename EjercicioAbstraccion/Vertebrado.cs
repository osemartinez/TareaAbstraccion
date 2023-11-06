using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public class Vertebrado : Animal
    {
        public string TipoEsqueleto { get; set; }
        public string Clase { get; set; }
        public string Especie { get; set; }
        

        

    public Vertebrado(string nombre, int edad, string habitat, bool esDepredador, string tipoEsqueleto, string clase, string especie)
        : base(nombre, edad, habitat, esDepredador)
           

        {
            TipoEsqueleto = tipoEsqueleto;
            Clase = clase;
            Especie = especie;
        }

        public Vertebrado()
        {
        }

        public override void Comer()
        {
            Console.WriteLine("Está comiendo");
        }

        public override void Moverse()
        {
            Console.WriteLine("Se está moviendo");
        }

        public override void Sonido()
        {
            Console.WriteLine("Emite un sonido");
        }
    }
}
