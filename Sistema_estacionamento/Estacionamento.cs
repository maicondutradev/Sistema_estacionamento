namespace Sistema_Estacionamento;
public class Estacionamento
{
    private decimal precoInicial = 0;
    private decimal precoPorHora = 0;
    private List<string?> veiculos = new List<string?>(); // Lista para armazenar as placas dos veículos estacionados

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial; // Inicializa o preço inicial do estacionamento
        this.precoPorHora = precoPorHora; // Inicializa o preço por hora do estacionamento
    }

    public void AdicionarVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para estacionar:");
        string? placa = Console.ReadLine(); // Captura a placa digitada pelo usuário
        veiculos.Add(placa); // Adiciona a placa à lista de veículos estacionados
        Console.WriteLine($"Veículo {placa} estacionado com sucesso!"); // Mensagem de confirmação
    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para remover:");
        string? placa = Console.ReadLine(); // Captura a placa digitada pelo usuário

        if (veiculos.Any(x => x.ToUpper() == placa.ToUpper())) // Verifica se a placa está na lista de veículos
        {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            int horas = Convert.ToInt32(Console.ReadLine()); // Captura as horas estacionadas
            decimal valorTotal = precoInicial + precoPorHora * horas; // Calcula o valor total a pagar

            veiculos.Remove(placa); // Remove o veículo da lista

            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}"); // Mensagem com o valor total
        }
        else
        {
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente"); // Mensagem de erro
        }
    }

    public void ListarVeiculos()
    {
        if (veiculos.Any()) // Verifica se há veículos na lista
        {
            Console.WriteLine("Os veículos estacionados são:");
            foreach (var veiculo in veiculos)
            {
                Console.WriteLine(veiculo); // Exibe cada placa de veículo estacionada
            }
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados."); // Mensagem quando não há veículos na lista
        }
    }
}