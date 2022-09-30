using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCPractica6_POO
{
    //Quinto ejemplo: Comentarios TODO, varios ficheros fuente (clase Punto en Punto.cs) y compilar
    class Punto //Creamos esta clase en un fichero aparte en el menú Proyecto-> Agregar nuevo elemento -> Clase
    {
        public Punto()
        {
            Console.WriteLine("Este es el constructor por defecto");
        }

        public Punto(int x, int y)
        {
            Console.WriteLine($"Constructor con parámetros: Coordenada x={x} Coordenada y={y}");
        }

    }
}
