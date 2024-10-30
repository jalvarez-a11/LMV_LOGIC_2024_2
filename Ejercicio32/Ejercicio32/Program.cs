using Ejercicio32;

public class Program
{
    private static void Main(string[] args)
    {
        // datos de entrada: numero de creditos, estracto socioeconomico, subcidio de alimentacion y transporte, valor por credito

        bool continuar = true;
        while (continuar)
        {
            Estudiantes estudiante = new Estudiantes();

            Console.Write("Ingrese el estrato: ");
            estudiante.Estrato = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de créditos: ");
            estudiante.Creditos = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor por crédito: ");
            estudiante.ValorCredito = double.Parse(Console.ReadLine());

            double matricula = estudiante.CalcularMatricula();
            double subsidio = estudiante.CalcularSubsidio();

            Console.WriteLine($"Costo de la matrícula: ${matricula}");
            Console.WriteLine($"Subsidio: ${subsidio}");

            Console.Write("¿Desea calcular otra matrícula? (s/n): ");
            continuar = Console.ReadLine().ToLower() == "s";
        }
    }
}