using System.Security.Cryptography;

public class Program
{
    private static void Main(string[] args)
    {
       // Un vendedor recibe un sueldo base más un 10 % extra por comisión de sus ventas, el vendedor desea saber cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes y el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones.
       // datos de entrada
       double Salario = 2500000;
       double Comision_Venta1, Comision_Venta2, Comision_Venta3, ComisionTotal;
        Console.Write("ingrese el valor de la primera venta ");
        double Venta1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el valor de la segunda venta ");
        double Venta2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el valor de la tercera venta ");
        double Venta3 = Convert.ToDouble(Console.ReadLine());

        // proceso

        Comision_Venta1 = Venta1 * 0.10;
        Comision_Venta2 = Venta2 * 0.10;
        Comision_Venta3 = Venta3 * 0.10;

        ComisionTotal = Comision_Venta1 + Comision_Venta2 + Comision_Venta3;

        double TotalSueldo = Salario + ComisionTotal;
        //venta mayor comision
        double MayorComision = Math.Max(Comision_Venta1, Math.Max(Comision_Venta2, Comision_Venta3));
        Console.WriteLine($"El sueldo total es: {TotalSueldo}");
        Console.WriteLine($"El comision total es: {ComisionTotal}");
    }
}