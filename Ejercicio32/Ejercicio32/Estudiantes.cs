using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio32
{
    public class Estudiantes
    {
        public int Estrato { get; set; }
        public int Creditos { get; set; }
        public double ValorCredito { get; set; }

        // metodos de mi clase Estudiantes
        public double CalcularMatricula()
        {

            double valorMatricula = 0;
            if (Creditos <= 20)
            {
                valorMatricula = Creditos * ValorCredito;
            }
            else
            {
                valorMatricula = 20 * ValorCredito + (Creditos - 20) * ValorCredito
     * 2;
            }

            // Aplicar descuento por estrato
            switch (Estrato)
            {
                case 1:
                    valorMatricula *= 0.2; // Descuento del 80%
                    break;
                case 2:
                    valorMatricula *= 0.5; // Descuento del 50%
                    break;
                case 3:
                    valorMatricula *= 0.7; // Descuento del 30%
                    break;
            }

            return valorMatricula;
        }

        public double CalcularSubsidio()
        {
            switch (Estrato)
            {
                case 1:
                    return 200000;
                case 2:
                    return 100000;
                default:
                    return 0;
            }
        }
    }
}
