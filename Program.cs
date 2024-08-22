using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace aula_3_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program start = new Program(); 
        }
        public Program() 
        {
            Logic logica = new Logic(); 

            Console.Write("Digite o valor: ");

            string svalor = Console.ReadLine();
            int valor = Convert.ToInt32(svalor);

            logica.logistica(valor);

        }
    }
}
