// See https://aka.ms/new-console-template for more information
using EjercicioAbstraccion;





{
    // Creamos instancias de las clases Vertebrado e Invertebrado
    
   

    Vertebrado perro = new Vertebrado();
    
    perro.Nombre = "Husky";
    perro.Edad = 3;
    perro.Habitat = "Tierra";
    perro.EsDepredador = true;
    perro.TipoEsqueleto = "Endoesqueleto";
    perro.Clase = "Mamífero";
    perro.Especie = "Canis lupus familiaris";

        
    



    // Mostramos los datos de las clases heredadas en la consola
    Console.WriteLine("Datos del perro:");
    Console.WriteLine("Nombre: " + perro.Nombre);
    Console.WriteLine("Edad:" + perro.Edad );
    Console.WriteLine("Habitat: " + perro.Habitat);
    Console.WriteLine("Es depredador:" + perro.EsDepredador);
    Console.WriteLine("Tipo de esqueleto: " + perro.TipoEsqueleto);
    Console.WriteLine("Clase: " + perro.Clase);
    Console.WriteLine("Especie:" + perro.Especie);
    Console.WriteLine();

    // Llamar a los métodos abstractos
    perro.Comer();
    perro.Moverse();
    perro.Sonido();

    Invertebrado araña = new Invertebrado();
    araña.Nombre = "Araña";
    araña.Edad = 3;
    araña.Habitat = "Telaraña";
    araña.EsDepredador= false;
    araña.Tipo = "Arachnida";
    araña.Clasificacion = "Arácnido";
    araña.TieneExoesqueleto = true;
        
        



    Console.WriteLine("\nDatos de la araña:");
    Console.WriteLine("Nombre: " + araña.Nombre);
    Console.WriteLine("Edad:" + araña.Edad);
    Console.WriteLine("Habitat:" + araña.Habitat);
    Console.WriteLine("Es depredador:" +araña.EsDepredador);
    Console.WriteLine("Phylum: " +  araña.Tipo);
    Console.WriteLine("Clasificación: " + araña.Clasificacion);
    Console.WriteLine("Tiene exoesqueleto: " + araña.TieneExoesqueleto);
    Console.WriteLine();

    
    // Llamar a los métodos abstractos
    araña.Comer();
    araña.Moverse();
    araña.Sonido();
}

