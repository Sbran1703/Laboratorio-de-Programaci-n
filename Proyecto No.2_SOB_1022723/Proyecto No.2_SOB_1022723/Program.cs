
namespace JuegodelDado
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadPartidas = 0; // Variable para almacenar la cantidad de partidas.
            int cantidadTiros = 0;    // Variable para almacenar la cantidad de tiros por partida.

            while (true) // Bucle para asegurarse de que se ingresen valores válidos.
            {
                // Solicita al usuario ingresar la cantidad de partidas a jugar.
                Console.Write("Ingrese la cantidad de partidas a jugar: ");
                if (!int.TryParse(Console.ReadLine(), out cantidadPartidas) || cantidadPartidas <= 0)
                {
                    Console.WriteLine("La cantidad de partidas ingresada no es válida. Debe ser un número entero positivo.");
                }
                else
                {
                    break; // Sale del bucle si la entrada es válida.
                }
            }

            while (true) // Bucle para asegurarse de que se ingresen valores válidos.
            {
                // Solicita al usuario ingresar la cantidad de tiros por partida.
                Console.Write("Ingrese la cantidad de tiros por partida: ");
                if (!int.TryParse(Console.ReadLine(), out cantidadTiros) || cantidadTiros <= 0)
                {
                    Console.WriteLine("La cantidad de tiros por partida ingresada no es válida. Debe ser un número entero positivo.");
                }
                else
                {
                    break; // Sale del bucle si la entrada es válida.
                }
            }

            Random random = new Random(); // Objeto para generar números aleatorios.
            int victorias = 0;            // Contador de partidas ganadas por el jugador.

            for (int i = 0; i < cantidadPartidas; i++) // Bucle "For"para jugar la cantidad de partidas ingresadas.
            {
                int puntosJugador = 0; // Puntos del jugador en la partida actual.
                int puntosCasa = 0;    // Puntos de la casa en la partida actual.
                int numerosPares = 0;  // Contador de tiros con números pares.
                int numerosImpares = 0; // Contador de tiros con números impares.
                int numerosIguales = 0; // Contador de tiros con números iguales.

                for (int j = 0; j < cantidadTiros; j++) // Bucle para simular los tiros en una partida.
                {
                    int dado1 = random.Next(1, 7); // Genera un número aleatorio para el primer dado.
                    int dado2 = random.Next(1, 7); // Genera un número aleatorio para el segundo dado.
                    int suma = dado1 + dado2;     // Calcula la suma de los dos dados.
                    int numtiro = j + 1;

                    Console.WriteLine("Tiro " + numtiro + ": el valor del Dado 1 es de: " + dado1 + ", el valor del Dado 2 es de: " + dado2 + " y la suma es de " + suma);

                    if (j == 0) // Primer tiro
                    {
                        if (suma == 12 || suma == 6)
                        {
                            puntosJugador += 12;
                            Console.WriteLine("El jugador gana 12 puntos en su primer tiro.");
                        }
                        else if (suma == 4 || suma == 6 || suma == 10)
                        {
                            puntosCasa += 12;
                            Console.WriteLine("El jugador pierde y la casa gana 12 puntos en su primer tiro.");
                        }
                        else
                        {
                            puntosJugador += suma;
                            Console.WriteLine($"El jugador gana {suma} puntos en su primer tiro.");
                        }
                    }
                    else
                    {
                        if (suma == 7 || suma == 11)
                        {
                            puntosJugador = 0;
                            Console.WriteLine("El jugador pierde todos sus puntos en el tiro actual.");
                        }
                    }

                    if (suma % 2 == 0)
                    {
                        numerosPares++; // Incrementa el contador de tiros con números pares.
                    }
                    else
                    {
                        numerosImpares++; // Incrementa el contador de tiros con números impares.
                    }

                    if (dado1 == dado2)
                    {
                        numerosIguales++; // Incrementa el contador de tiros con números iguales.
                    }
                }

                if (puntosJugador > puntosCasa)
                {
                    Console.WriteLine("El jugador gana la partida con un punteo final de" + puntosJugador + "puntos.");
                    victorias++; // Incrementa el contador de partidas ganadas por el jugador.
                }
                else if (puntosJugador < puntosCasa)
                {
                    Console.WriteLine("La casa gana la partida con un punteo final de" + puntosCasa + "puntos.");
                }
                else
                {
                    Console.WriteLine("La partida termina en empate.");
                }

                Console.WriteLine("Números pares: " + numerosPares + ", impares: " + numerosImpares + ", iguales: " + numerosIguales);
                Console.WriteLine();
            }
            double probganar = victorias / cantidadPartidas * 100;
            // Calcula y muestra el resultado final de las partidas, incluida la probabilidad de ganar.
            Console.WriteLine("Resultado final: El jugador ganó " + victorias + " de " + cantidadPartidas + " partidas, con una probabilidad de ganar de " + probganar);
            Console.ReadKey();
        }
    }
}


