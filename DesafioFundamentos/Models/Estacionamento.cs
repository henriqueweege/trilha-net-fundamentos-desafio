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
            var placa = LerPlaca("Digite a placa do veículo para estacionar: ");
            if(!string.IsNullOrWhiteSpace(placa))
            {
                veiculos.Add(placa);
            }
            else
            {
                Print("Placa não pode ser vazia.");
            }
        } 

        private string LerPlaca(string mensagem)
        {
            Print(mensagem);
            return Console.ReadLine().ToUpper(); 
        }

        private void Print(string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        public void RemoverVeiculo()
        {
            string placa = LerPlaca("Digite a placa do veículo para remover:  ");

            if (veiculos.Any(x => x == placa))
            {
                int horas = 0;
                Print("Digite a quantidade de horas que o veículo permaneceu estacionado:  ");
                if(int.TryParse(Console.ReadLine(), out horas))
                {
                    decimal valorTotal = precoInicial + (precoPorHora * horas); 

                    veiculos.Remove(placa);

                    Print($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                else
                {
                    Print("O tempo de permanência informado precisa ser um número inteiro.");
                }

            }
            else
            {
                Print("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Print("Os veículos estacionados são:");
                for(var i =0; i< veiculos.Count; i++)
                {
                    Print(veiculos[i]);
                }
            }
            else
            {
                Print("Não há veículos estacionados.");
            }
        }
    }
}
