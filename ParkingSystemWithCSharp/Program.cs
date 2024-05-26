// Coloca o encoding para UTF8 para exibir acentuação
using ParkingSystemWithCSharp.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("***********************************");
Console.WriteLine("***  SISTEMA DE ESTACIONAMENTO  ***");
Console.WriteLine("***      Seja bem-vindo(a).     ***");
Console.WriteLine("***********************************");

Console.WriteLine("Digite o preço inicial: ");
//precoInicial = Convert.ToDecimal(Console.ReadLine());
decimal.TryParse(Console.ReadLine(), out precoInicial);

Console.WriteLine("Digite o preço por hora:");
//precoPorHora = Convert.ToDecimal(Console.ReadLine());
decimal.TryParse(Console.ReadLine(), out precoPorHora);

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("***********************************");
    Console.WriteLine("***  SISTEMA DE ESTACIONAMENTO  ***");
    Console.WriteLine("***             MENU            ***");
    Console.WriteLine("***********************************");
    Console.WriteLine("[1] Cadastrar veículo");
    Console.WriteLine("[2] Remover veículo");
    Console.WriteLine("[3] Listar veículos");
    Console.WriteLine("[4] Encerrar programa");

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
            Console.Clear();
            Console.WriteLine("***********************************");
            Console.WriteLine("***  Fim do programa. Bye bye!  ***");
            Console.WriteLine("***********************************");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Erro: Opção inválida");
            break;
    }

    Console.WriteLine("------------------------------------");
    Console.WriteLine(" Pressione uma tecla para continuar");
    Console.WriteLine("------------------------------------");
    Console.ReadLine();
}



