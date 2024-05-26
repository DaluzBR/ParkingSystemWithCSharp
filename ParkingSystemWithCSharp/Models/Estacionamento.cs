using System.Globalization;

namespace ParkingSystemWithCSharp.Models
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

            // Lista de veículos pré preenchida.
            veiculos.Add("ABC1234");
            veiculos.Add("TYU4563");
            veiculos.Add("YUI4125");
            veiculos.Add("WER2130");
            veiculos.Add("VBN7862");
            veiculos.Add("XCV4567");
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.Clear();
            Console.WriteLine("***********************************");
            Console.WriteLine("***      Cadastrar veículo      ***");
            Console.WriteLine("***********************************");
            Console.WriteLine("Digite a placa do veículo para estacionar (EX.: DRT5236, REW2G89, etc.): ");

            string placa = Console.ReadLine();

            if (!VerificarPlaca(placa))
            {
                return;
            }
            if (veiculos.Contains(placa))
            {
                Console.WriteLine($"Erro: O veículo de placa {placa} já está estacionado.");
                return;
            }

            veiculos.Add(placa);

            Console.WriteLine("Aviso: Placa inserida com sucesso.");
        }

        public void RemoverVeiculo()
        {
            Console.Clear();
            Console.WriteLine("***********************************");
            Console.WriteLine("***       Remover veículo       ***");
            Console.WriteLine("***********************************");
            Console.WriteLine("Digite a placa do veículo para remover: ");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine();

            if (!VerificarPlaca(placa))
            {
                return;
            }

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: {valorTotal.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}");
            }
            else
            {
                Console.WriteLine("Aviso: Veículo não encontrado.");

            }
        }

        public void ListarVeiculos()
        {
            Console.Clear();
            Console.WriteLine("***********************************");
            Console.WriteLine("***       Listar veículos       ***");
            Console.WriteLine("***********************************");

            // Verifica se há veículos no estacionamento
            if (veiculos.Count != 0)
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*

                for (int i = 0; i < veiculos.Count; i++)
                {
                    Console.WriteLine($"{(i + 1).ToString().PadLeft(4, '0')} - {veiculos[i]}");
                }
            }
            else
            {
                Console.WriteLine("Aviso: Não há veículos estacionados.");
            }
        }

        private bool VerificarPlaca(string placa)
        {
            if (placa == null)
            {
                Console.WriteLine("Erro: Placa nula ou vazia.");
                return false;
            }

            if (placa.Length != 7)
            {
                Console.WriteLine($"Erro: Placa inválida ({placa}).");
                return false;
            }



            return true;
        }
    }
}
