using System.Runtime.InteropServices;
using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;



decimal precoInicial = 0;
decimal precoPorHora = 0;

if (Environment.UserInteractive)
{
    Console.Clear();
}

Console.WriteLine("Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);
es.Limpa();
Console.ForegroundColor = ConsoleColor.Green;
es.FillLine('*');
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Yellow;
es.CentralizarTexto("Seja bem vindo ao sistema de estacionamento!");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
es.FillLine('*');
Console.ResetColor();

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    //es.Limpa();
    //Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    //Console.WriteLine("Pressione uma tecla para continuar");
    //Console.ReadLine();
}

es.Limpa();
Console.WriteLine("\n\n\n\n");
Console.ForegroundColor = ConsoleColor.Red;
es.CentralizarTexto("O programa se encerrou");
Console.ResetColor();
Console.WriteLine("\n\n\n\n\n\n\n\n");
Console.ReadLine();
es.Limpa();
