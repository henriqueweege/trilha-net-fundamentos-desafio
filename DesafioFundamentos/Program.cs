using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;
var receberParametro = true;
while(receberParametro)
{
    Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
    if(decimal.TryParse(Console.ReadLine(), out precoInicial))
    {
        receberParametro = false;
    }
    else
    {
        Console.WriteLine("Preço por hora precisa ser um número. Aperte qualquer tecla para tentar novamente.");
        Console.ReadKey();

    }

}
receberParametro = true;
while(receberParametro)
{
    Console.WriteLine("Agora digite o preço por hora:");
    if(decimal.TryParse(Console.ReadLine(), out precoPorHora))
    {
        receberParametro = false;
    }
    else
    {
        Console.WriteLine("Preço por hora precisa ser um número. Aperte qualquer tecla para tentar novamente.");
        Console.ReadKey();
    }
}


// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
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

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
