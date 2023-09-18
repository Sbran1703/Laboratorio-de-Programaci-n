using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LASOB1022723
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio No.01 Operaciones Aritmèticas");

            Console.WriteLine("Ingrese un número");
            string numero1 = Console.ReadLine();
            int num1 = Convert.ToInt32(numero1);


            Console.WriteLine("Ingrese un número");
            string numero2 = Console.ReadLine();
            int num2 = Convert.ToInt32(numero2);

            Console.WriteLine("Ingrese un número");
            string numero3 = Console.ReadLine();
            int num3 = Convert.ToInt32(numero3);

            //Suma
            int suma = num1 + num2; 
            Console.WriteLine("Suma: " + num1 + " + " + num2 + " = " + suma );
            Console.ReadKey();

            //Resta
            int resta = num1 - num2;
            Console.WriteLine(" Resta:" + num1 + "-" + num2 + " - " + resta);
            Console.ReadKey();

            //Multiplicación
            int multiplicación = num1 * num2;
            Console.WriteLine("multiplicaciòn" + num1 + "*" + num2 + "=" + multiplicación);
            Console.ReadKey();

            //División
            int división = num1 / num2;
            Console.WriteLine("división" + num1 + "/" + num2 + "=" + división);
            Console.ReadKey();

            //Mod
            int Mod = num1 % num2;
            Console.WriteLine("Mod" + num1 + "%" + num2 + "=" + Mod);
            Console.ReadKey();

            Console.WriteLine("Ejercicio 2: operaciones booleanas");

            if (num1 > num2) 
            {
                Console.WriteLine(num1 + " es mayor que: " + num2);
            }
            else if (num1 < num2) 
            {
                Console.WriteLine(num1 + " es menor que:" + num2);

            }
            else if (num1 == num2) 
            {
                Console.WriteLine(num1 + " es igual que:" + num2);

            }
        
            //Ejercicio No.3
            Console.WriteLine("Ejercicio No.3: jerarquía de operaciones");

            //operación 1 
            int operación1 = num1 * num2 + num3;
            Console.WriteLine("operación1:" + num1 + "*" + num2 + "+" + num3 + "=" + operación1);
            Console.ReadKey();

            //operación 2 
            int operación2 = num1 + num2 + num3;
            Console.WriteLine("operación2:" + num1 + "+" + num2 + "+" + num3 + "=" + operación2);
            Console.ReadKey();

            //operación 3
            int operación3 = num1 / num2 + num3;
            Console.WriteLine("operación2:" + num1 + "/" + num2 + "+" + num3 + "=" + operación3);
            Console.ReadKey();

        }

    }

}


