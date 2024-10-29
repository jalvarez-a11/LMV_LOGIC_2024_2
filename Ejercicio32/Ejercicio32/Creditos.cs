using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio32
{
    public class Creditos
    {
        // propiedades de mi clase creditos
        public int Estrato { get; set; }

        public int Credito { get; set; }

        // metodos de mi clase Creditos
        public void Pagar() {
            
            Console.WriteLine($"Ingerse el numero de creditos a tomar: {Credito} ");
            {
                if (Credito <= 20)
                {
                    Console.WriteLine("Paga el credito al valor normal");
                }

            }
        }
    }
}
