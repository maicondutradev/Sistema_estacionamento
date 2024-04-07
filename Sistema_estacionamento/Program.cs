namespace Sistema_Estacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a codificação de saída para UTF-8 para suportar caracteres especiais
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Variáveis para armazenar o preço inicial e o preço por hora do estacionamento
            decimal precoInicial = 0;
            decimal precoPorHora = 0;

            // Solicita ao usuário que digite o preço inicial do estacionamento
            Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                              "Digite o preço inicial:");
            precoInicial = Convert.ToDecimal(Console.ReadLine());

            // Solicita ao usuário que digite o preço por hora do estacionamento
            Console.WriteLine("Agora digite o preço por hora:");
            precoPorHora = Convert.ToDecimal(Console.ReadLine());

            // Cria uma instância da classe Estacionamento com os preços informados
            Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

            // Variável para controlar se o menu deve continuar sendo exibido
            bool exibirMenu = true;

            // Loop do menu principal
            while (exibirMenu)
            {
                Console.Clear(); // Limpa a tela para exibir o menu
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Remover veículo");
                Console.WriteLine("3 - Listar veículos");
                Console.WriteLine("4 - Encerrar");

                // Captura a opção escolhida pelo usuário
                switch (Console.ReadLine())
                {
                    case "1": // Opção para cadastrar um veículo
                        estacionamento.AdicionarVeiculo();
                        break;

                    case "2": // Opção para remover um veículo
                        estacionamento.RemoverVeiculo();
                        break;

                    case "3": // Opção para listar os veículos estacionados
                        estacionamento.ListarVeiculos();
                        break;

                    case "4": // Opção para encerrar o programa
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida"); // Mensagem para opções inválidas
                        break;
                }

                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine(); // Pausa a execução para o usuário visualizar as mensagens
            }

            Console.WriteLine("O programa se encerrou"); // Mensagem de encerramento do programa
        }
    }
}