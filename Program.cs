using estacionamento.Models;
Console.Clear();
Console.WriteLine("Olá! Seja bem vindo ao sistema de estacionamento!");
Console.WriteLine("Digite o preço inicial: ");
Estacionamento estacionamento = new Estacionamento();

string inputPrecoInicial = Console.ReadLine();
decimal precoInicial = 0;
decimal.TryParse(inputPrecoInicial, out precoInicial);
estacionamento.PrecoInicial = precoInicial;

Console.WriteLine("Agora digite o preço por hora: ");
string inputPrecoPorHora = Console.ReadLine();
decimal precoPorHora = 0;
decimal.TryParse(inputPrecoPorHora, out precoPorHora);

estacionamento.PrecoPorHora = precoPorHora;

bool sistemaRodando = true;
string menu = "\n1 - Cadastrar Veículo\n2 - Remover Veículo\n3 - Listar Veículo\n4 - Encerrar";
string reset = "Pressione enter";

Console.Clear();
Console.WriteLine(menu);

while (sistemaRodando)
{   string opcao = Console.ReadLine();
    switch(opcao)
    {
        case "1":
            Console.WriteLine("Digite a placa do veículo: ");
            string placaCadastrar = Console.ReadLine();
            estacionamento.CadastrarVeiculo(placaCadastrar);
            Console.WriteLine(reset);
            break;
        case "2":
            Console.WriteLine("Digite a placa do veículo: ");
            string placaRemover = Console.ReadLine();
            estacionamento.RemoverVeiculo(placaRemover);
            Console.WriteLine(reset);
            break;
        case "3":
            estacionamento.ListarVeiculosEstacionados();
            Console.WriteLine(reset);        
            break;
        case "4":
            sistemaRodando = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine(menu);
            break;

    }
}

Console.WriteLine("Sitema Encerrando");

Environment.Exit(0);