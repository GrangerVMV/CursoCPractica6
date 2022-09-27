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
            Console.WriteLine(miCirculo.CalculoArea(5));
            Circulo miCirculo2 = new Circulo(); //Alta de objeto e instancia en la misma linea
            Console.WriteLine(miCirculo2.CalculoArea(9));

            // Segundo ejemplo: Encapsulación y modificador mediante métodos de acceso

            ConversorEuroDolar obj = new ConversorEuroDolar(); // Constructor
            Console.WriteLine(obj.convierte(50)); // convierte 25 dolares a euros
            obj.cambiaValorEuro(2); // Modifica el valor de euro mediante método de acceso. 
            //obj.cambiaValorEuro(-7.850); // No permite el uso de valores negativos
            Console.WriteLine(obj.convierte(50));
        }
    }

    class Circulo //Ejemplo 1: Creación de clase, objeto de clase e instancia de la clase(inicialización y llamada)
    {
        private const double pi = 3.1416; // Propiedad de la clase círculo. Campo de clase. Se define como constante para que sea invariable. Es private es para que no sea accesible desde fuera
        public double CalculoArea (int radio) // Método de clase. ¿Qué pueden hacer los objetos de tipo clase?. Al ser publica usaremos notacion PascalCase
        {
            return pi * radio * radio;
        }

    }
    class ConversorEuroDolar //Segundo ejemplo: Encapsulación y modificador mediante métodos de acceso
    {
        private double euro = 1.253;
        public double convierte(double cantidad) 
        {
            return cantidad * euro;
        }

        public void cambiaValorEuro(double nuevoValor) // Esto es un método de acceso. Sirve para poder cambiar el valor de una variable desde fuera de la clase bajo unas condiciones
        {
            if (nuevoValor < 0) Console.WriteLine("No se admiten valores negativos");
            else euro = nuevoValor;
        }
    }


}
