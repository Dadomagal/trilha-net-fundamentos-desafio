using System.Text.RegularExpressions;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
        
        public void AdicionarVeiculo()
        {
            // Implementado!!!!!
            Console.WriteLine("Digite a placa a ser adicionada, no formato: XXX-123 OU AAA1A23");
            string placa = Console.ReadLine()?.Trim().ToUpper() ?? "";
            var padraoMercosul = new Regex(@"(^[A-Z]{3}-\d{4}$)|(^[A-Z]{3}\d[A-Z]\d{2}$)");
            if (padraoMercosul.IsMatch(placa))
            {
                if (!veiculos.Contains(placa))
                {
                    veiculos.Add(placa);
                    Console.WriteLine($"Veículo de placa {placa} cadastrado com sucesso."); 
                }
                else
                {
                    Console.WriteLine($"O veículo de placa {placa} já foi cadastrado");
                }

            }
            else
            {
                Console.WriteLine($"Formato {placa} inválido! ");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine()?.Trim().ToUpper() ?? "";

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = 0;
                decimal valorTotal = 0;

                var totalHoras = Convert.ToInt32(Console.ReadLine());
                if (totalHoras > 0)
                {
                    horas = totalHoras;
                    valorTotal = precoInicial + precoPorHora * horas;
                }
                else
                {
                    Console.WriteLine("Total de horas inválido.");
                }
                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                foreach (string item in veiculos)
                {
                    Console.WriteLine($"{item}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
