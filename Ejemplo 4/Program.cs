using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0, b = 0;
            string resp = "0";
            char opt;

            //Impresion
            Console.WriteLine("Ingrese el primer numero");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la opción a ejecutar");
            Console.WriteLine("a.Sumar\n" + "b.Restar\n" + "c.Multiplicar\n" + "d.Dividir\n");
            opt = char.Parse(Console.ReadLine());

            //Mando a solicitar la funcion operacion y envio los parametros solicitados
            resp = operacion(a,b,opt);

            Console.WriteLine("La respuesta es: " + resp);
            Console.ReadKey();
        }

        public static string operacion(int num1, int num2, char opcion)
        {
            switch (opcion)
            {
                case 'a':
                    return Convert.ToString(sumarNumeros(num1, num2));
                case 'b':
                    return Convert.ToString(restarNumeros(num1, num2));
                case 'c':
                    return Convert.ToString(multiplicarNumeros(num1, num2));
                case 'd':
                    return Convert.ToString(dividirNumeros(num1, num2));
                default:
                    Console.WriteLine("Opción no valida");
                    return "";
            }
        }

        public static int sumarNumeros(int x, int y)
        {
            return (x + y);
        }

        public static int restarNumeros(int x, int y)
        {
            return (x - y);
        }

        public static int multiplicarNumeros(int x, int y)
        {
            return (x * y);
        }

        public static int dividirNumeros(int x, int y)
        {
            return (x / y);
        }
    }
}
