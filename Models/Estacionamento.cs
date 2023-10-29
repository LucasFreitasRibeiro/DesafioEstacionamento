namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover: ");
            string placa = Console.ReadLine();

            if(veiculos.Any(x => x.ToUpper() == placa.ToUpper())) {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                int horas = int.Parse(Console.ReadLine());

                decimal valorTotal = (precoInicial + precoHora) * horas;

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preo total foi de R${valorTotal}");
            }
            else {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira a polaca corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
          if(veiculos.Any()) {
                Console.WriteLine("Os veículos estacionados são: ");
                int contatorVeiculos = 0;
                foreach(string placa in veiculos) {
                    Console.WriteLine(placa);
                    contatorVeiculos++;
                }
            }
        }
    }
}
