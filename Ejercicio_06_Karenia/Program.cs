using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06_Karenia
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rec1 = new Rectangulo("Rectangulo 1", 20, 30);
            Circulo cir1 = new Circulo("Circulo 1", 30);

            Console.WriteLine(rec1.ToString());
            Console.WriteLine(cir1.ToString());
            Console.ReadKey();
        }
    }
}
