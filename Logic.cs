using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace aula_3_ex3
{
    internal class Logic
    {
        public void logistica(int valor) 
        {
            int[] notas = { 100, 50, 20, 10, 5, 2, 1 };
            int valoratual;

            valoratual = valor;

            foreach (int nota in notas)
            {
                int aux = 0;
                while (valoratual >= nota)
                {
                    valoratual = valor - nota;
                    valor = valoratual;
                    aux++;
                    if (valoratual == 0)
                    {
                        break;
                    }
                }
                Console.WriteLine("{0}-nota(s) de {1}", aux, nota);
            }
            Console.ReadKey();
        }
    }
}
