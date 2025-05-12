using Newtonsoft.Json;
using Questao3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao3.Controller
{
    public class JsonController
    {
        public void AnalisarFaturamento()
        {
            //trocar o caminho para o local do arquivo salvo na máquina
            string caminho = "F:\\Download\\arquivos teste target\\dados.json";
            string json = File.ReadAllText(caminho);

            
            List<DadosDiario> dados = JsonConvert.DeserializeObject<List<DadosDiario>>(json);
           
            var diasComFaturamento = dados.Where(d => d.Valor > 0).ToList();

            decimal menor = diasComFaturamento.Min(d => d.Valor);
            decimal maior = diasComFaturamento.Max(d => d.Valor);
            decimal media = diasComFaturamento.Average(d => d.Valor);
            int diasAcimaMedia = diasComFaturamento.Count(d => d.Valor > media);

            Console.WriteLine($"Menor faturamento: {menor}");
            Console.WriteLine($"Maior faturamento: {maior}");
            Console.WriteLine($"Dias com faturamento acima da média ({media:F2}): {diasAcimaMedia}");
                   
        }
    }
}
