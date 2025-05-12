using Questao4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao4.Controller
{
    public class FaturamentoController
    {
        public void CalcularPercentualFaturamento()
        {
            var faturamentos = new List<Dados>
            {
                new Dados { Estado = "SP", Valor = 67836.43m },
                new Dados { Estado = "RJ", Valor = 36678.66m },
                new Dados { Estado = "MG", Valor = 29229.88m },
                new Dados { Estado = "ES", Valor = 27165.48m },
                new Dados { Estado = "Outros", Valor = 19849.53m },
            };

            decimal total = faturamentos.Sum(f => f.Valor);

            Console.WriteLine($"Faturamento total: R$ {total:F2}\n");

            foreach (var f in faturamentos)
            {
                decimal percentual = (f.Valor / total) * 100;
                Console.WriteLine($"{f.Estado}: {percentual:F2}%");
            }
        }
    }
}
