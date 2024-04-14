using System.Security.Cryptography.X509Certificates;

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
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            //implementado
            string placa = "";

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placa = Console.ReadLine();
            veiculos.Add(placa);
            //implementado
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            //implementado
            string placa = "";
            Console.WriteLine("Digite a placa do veículo para remover:");
            placa = Console.ReadLine();
            //implementado

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                //implementado
                int horas = 0;
                decimal valorTotal = 0;
                horas = Convert.ToInt32(Console.ReadLine());

                valorTotal = precoInicial + precoPorHora * horas;
                //implementado

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                //implementado
                veiculos.Remove(placa);
                //implementado
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
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
                //implementado
                int qtde = 0;
                foreach (var item in veiculos)
                {
                    qtde++;
                    Console.WriteLine($"{qtde} - {item}");
                }
                //implementado
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
        public void Limpa()
        {
            if (Environment.UserInteractive)
            {
                Console.Clear();
            }
        }

        public void CentralizarTexto(string texto)
        {
            int windowWidth = Console.WindowWidth;
            int xPos = (windowWidth - texto.Length) / 2;
            Console.SetCursorPosition(xPos, Console.CursorTop);
            Console.WriteLine(texto);
        }

        public void FillLine(char symbol)
    {
        int windowWidth = Console.WindowWidth;
        string line = new string(symbol, windowWidth);
        Console.WriteLine(line);
    }
    }
}
