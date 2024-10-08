public class Program
{
    private static void Main(string[] args)
    {
        int numeroJugadores;
        int numeroAleatorio;
        bool jugarDeNuevo = true;

        while (jugarDeNuevo)
        {
            Console.WriteLine("¡Bienvenido al juego Adivina el Número!");

            // Obtener el número de jugadores
            do
            {
                Console.Write("Ingrese el número de jugadores (2-4): ");
            } while (!int.TryParse(Console.ReadLine(), out numeroJugadores) || numeroJugadores < 2 || numeroJugadores > 4);

            // Generar el número aleatorio según la cantidad de jugadores
            Random random = new Random();
            switch (numeroJugadores)
            {
                case 2:
                    numeroAleatorio = random.Next(0, 51);
                    break;
                case 3:
                    numeroAleatorio = random.Next(0, 101);
                    break;
                default:
                    numeroAleatorio = random.Next(0, 201);
                    break;
            }

            // Bucle principal del juego
            bool juegoTerminado = false;
            int jugadorActual = 1;
            while (!juegoTerminado)
            {
                Console.WriteLine($"Jugador {jugadorActual}, ingresa un número:");
                int numeroIngresado;
                if (int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    if (numeroIngresado == numeroAleatorio)
                    {
                        Console.WriteLine("¡HAS GANADO!");
                        juegoTerminado = true;
                    }
                    else if (numeroIngresado < numeroAleatorio)
                    {
                        Console.WriteLine("MAYOR");
                    }
                    else
                    {
                        Console.WriteLine("MENOR");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Ingresa un número entero.");
                }

                jugadorActual = (jugadorActual % numeroJugadores) + 1; // Pasar al siguiente jugador
            }

            // Preguntar si desean jugar de nuevo
            Console.Write("¿Deseas jugar de nuevo? (s/n): ");
            jugarDeNuevo = Console.ReadLine().ToLower() == "s";

            // Limpiar la consola
            Console.Clear();
        }
    }
}

    
