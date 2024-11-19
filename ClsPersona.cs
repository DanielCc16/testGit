using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoPoo
{
    class ClsPersona
    {
        // Propiedades de la clase
        public string Nombre { get; set; }
        public int Edad { get; set; }

        // Constructor de la clase
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        // Método de la clase
        public void Saludar()
        {
            Console.WriteLine($"¡Hola! Mi nombre es {Nombre} y tengo {Edad} años.");
        }

        // Método que devuelve una representación en cadena de la persona
        public override string ToString()
        {
            return $"{Nombre}, {Edad} años";
        }

    }

    // Clase principal para probar la clase Persona
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de la clase Persona
            Persona persona1 = new Persona("Juan", 30);

            // Llamar al método Saludar de la clase Persona
            persona1.Saludar();

            // Imprimir la representación de la persona usando ToString()
            Console.WriteLine(persona1.ToString());

            Console.ReadKey();
        }
    }


}
