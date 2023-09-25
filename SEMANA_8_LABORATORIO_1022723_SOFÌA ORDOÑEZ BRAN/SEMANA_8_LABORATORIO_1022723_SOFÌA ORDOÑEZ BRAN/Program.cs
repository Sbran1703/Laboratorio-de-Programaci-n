using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero mayor que 0: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            int a = 0, b = 1, c;
            int i = 0;

            Console.WriteLine("Secuencia de Fibonacci hasta el término N:");
            Console.Write(a + " " + b + " ");

            while (i < n - 2)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
                i++;
            }

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Debe ingresar un número entero mayor que 0.");
        }
    }
}

