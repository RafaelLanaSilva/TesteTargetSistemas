using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao5.Controller
{
    public class StringController
    {
        public void InverterString()
        {
            Console.WriteLine("Escreva uma palavra");
            var palavra = Console.ReadLine();

            string resultado = string.Empty;

            for (int i = palavra.Length - 1; i >= 0; i--)
            {
                resultado += palavra[i];
            }

            Console.WriteLine($"Palavra invertida: {resultado}");
        }
    }
}
