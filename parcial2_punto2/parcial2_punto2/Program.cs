public class Program
{
    private static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Ingrese la cantidad de estudiantes:");
            int cantidadEstudiantes = int.Parse(Console.ReadLine());

            double[] notas = new double[cantidadEstudiantes];

            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                Console.Write($"Ingrese la nota del estudiante {i + 1}: ");
                notas[i] = double.Parse(Console.ReadLine());
            }

            // Calcular promedios y clasificar
            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                double promedio = notas[i];
                string categoria;

                if (promedio >= 4.5)
                {
                    categoria = "Excelente";
                }
                else if (promedio >= 4.0)
                {
                    categoria = "Sobresaliente";
                }
                else if (promedio >= 3.5)
                {
                    categoria = "Bueno";
                }
                else
                {
                    categoria = "Insuficiente";
                }

                Console.WriteLine($"El estudiante {i + 1} tiene un promedio de {promedio:N2} y está en la categoría {categoria}");
            }

            // Preguntar si desea continuar
            Console.WriteLine("¿Desea ingresar otro grupo de estudiantes? (s/n): ");
            continuar = Console.ReadLine().ToLower() == "s";
        }
    }
}

    
