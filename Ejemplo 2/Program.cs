using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int a = 0, b = 0,resp=0;
            char opt;

            //Impresion
            Console.WriteLine("Ingrese el primer numero");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la opción a ejecutar");
            Console.WriteLine("a. Sumar\n" + "b.Restar\n" + "c.Multiplicar\n" + "d.Dividir\n");
            opt = char.Parse(Console.ReadLine());

            switch (opt)
            {
                case 'a':
                    //resp = a + b;
                    sumarNumeros(a,b);
                    break;
                case 'b':
                    //resp = a - b;
                    restarNumeros(a,b);
                    break;
                case 'c':
                    //resp = a * b;
                    multiplicarNumeros(a,b);
                    break;
                case 'd':
                    //resp = a / b;
                    dividirNumeros(a,b);
                    break;
                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }

            //Console.WriteLine("La respuesta es: " + Convert.ToString(resp));
            Console.ReadKey();
        }

        //Fuera del main pero dentro de la clase
        //En esta funcion recibimos los valores en parametros
        public static void sumarNumeros(int x, int y) 
        {
            Console.WriteLine("La respuesta es: " + Convert.ToString(x+y));
        }

        public static void restarNumeros(int x, int y)
        {
            Console.WriteLine("La respuesta es: " + Convert.ToString(x - y));
        }

        public static void multiplicarNumeros(int x, int y)
        {
            Console.WriteLine("La respuesta es: " + Convert.ToString(x * y));
        }

        public static void dividirNumeros(int x, int y)
        {
            Console.WriteLine("La respuesta es: " + Convert.ToString(x / y));
        }


    }
}
