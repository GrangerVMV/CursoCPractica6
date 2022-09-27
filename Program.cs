using System;


namespace CursoCPractica6_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo 1: Creación de clase, objeto de clase e instancia de la clase (inicialización y llamada)
            Circulo miCirculo; //Creación de objeto de tipo círculo. Variable/objeto de tipo círculo.
            miCirculo = new Circulo(); //Iniciación de variable de tipo Circulo. Instanciar una clase
            //Instanciación. Ejemplarización.Creación de ejemplar de clase
            Console.WriteLine(miCirculo.calculoArea(5));
            Circulo miCirculo2 = new Circulo(); //Alta de objeto e instancia en la misma linea
            Console.WriteLine(miCirculo2.calculoArea(9));           
        }
    }

    class Circulo //Ejemplo 1: Creación de clase, objeto de clase e instancia de la clase(inicialización y llamada)
    {
        const double pi = 3.1416; // Propiedad de la clase círculo. Campo de clase. Se define como constante para que sea invariable
        public double calculoArea (int radio) // Método de clase. ¿Qué pueden hacer los objetos de tipo clase?
        {
            return pi * radio * radio;
        }

    }

}
