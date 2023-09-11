using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  L2SOB1022723
{
    using System;

namespace DiaDeLaSemana
{
    class Program
    {
           
        static void Main(string[] args)
        {
            // Agregamos la instrucción que muestra "Ejercicio 2"
            Console.WriteLine("Ejercicio 2");

            // Solicitamos al usuario ingresar el número de día
            Console.Write("Ingrese el número de día (1-lunes, 2-martes, 3-miércoles, 4-jueves, 5-viernes, 6-sábado, 7-domingo): ");
                int numeroDia = int.Parse(Console.ReadLine());
                
            // Verificamos si el número está dentro del rango válido
            if (numeroDia >= 1 && numeroDia <= 7)
            {
                    // Utilizamos if para evaluar qué día corresponde al número ingresado de la semana 
                     if (numeroDia == 1)
                    {
                        Console.WriteLine("Lunes");
                    }
                    else if (numeroDia == 2)
                    { 
                        Console.WriteLine("Martes");
                    }
                    else if (numeroDia == 3)
                    {
                        Console.WriteLine("Miercoles");
                    }
                    else if (numeroDia == 4)
                    {
                        Console.WriteLine("Juves");
                    }
                    else if (numeroDia == 5)
                    {
                        Console.WriteLine("Viernes");
                    }
                    else if (numeroDia == 6)
                    {
                        Console.WriteLine("Sabado");
                    }
                    else if (numeroDia == 7)
                    {
                        Console.WriteLine("Domingo");
                    }
                    
               
                
                
            }
                 Console.ReadKey();
            }
        }

        }
    }



    