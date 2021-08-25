using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            //int a = 0, b = 0,resp=0;
            char opt;

            //Impresion
            //Console.WriteLine("Ingrese el primer numero");
            //a = int.Parse(Console.ReadLine());

            //Console.WriteLine("Ingrese el segundo numero");
            //b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la opción a ejecutar");
            Console.WriteLine("a. Sumar\n"+ "b.Restar\n"+ "c.Multiplicar\n"+ "d.Dividir\n");
            opt = char.Parse(Console.ReadLine());

            switch (opt)
            {
                case 'a':
                    //resp = a + b;
                    sumarNumeros();
                    break;
                case 'b':
                    //resp = a - b;
                    restarNumeros();
                    break;
                case 'c':
                    //resp = a * b;
                    multiplicarNumeros();
                    break;
                case 'd':
                    //resp = a / b;
                    dividirNumeros();
                    break;
                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }

            //Console.WriteLine("La respuesta es: " + Convert.ToString(resp));
            Console.ReadKey();
        }
        
        //Esto es afuera del main, pero siempre dentro de la clase
        public static void sumarNumeros()
        {
            int a, b;
            Console.WriteLine("Ingrese el primer numero");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("La respuesta es: " + Convert.ToString(a+b));
        }

        public static void restarNumeros()
        {
            int a, b;
            Console.WriteLine("Ingrese el primer numero");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("La respuesta es: " + Convert.ToString(a - b));
        }

        public static void multiplicarNumeros()
        {
            int a, b;
            Console.WriteLine("Ingrese el primer numero");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("La respuesta es: " + Convert.ToString(a * b));
        }

        public static void dividirNumeros()
        {
            int a, b;
            Console.WriteLine("Ingrese el primer numero");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("La respuesta es: " + Convert.ToString(a / b));
        }
    }
}
