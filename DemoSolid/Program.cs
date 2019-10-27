using System;

namespace DemoSolid
{
    class X
    {
        public string Nombre { get; set; }
    }

    class Y: X
    {
        public string Direccion { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            X x = new X();
            Y y = new Y();
            x = y; // Sustitución Liskov
            y = (Y)x; // Cast tipo C++: Si la asignación es inválida genera InvalidCastException.
            y = x as Y; // Cast estilo C#: Si la asignación es inválida devuelve nulo.
            y.Direccion = "Calle 100";
        }
    }
}
