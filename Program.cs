using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace aula_3_ex3
{
    
    /* Escreva um programa em C# que lê um valor inteiro em reais e calcula e escreve 
    qual o menor número possível de notas de 100,50,20,10,5,2 e 1 real em que o 
    valor pode ser decomposto.*/
    
    public class Program
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
