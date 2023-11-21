namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private decimal totalFaturamento = 0;
        private decimal totalVeiculosJaEstacionados = 0;
        private List<string> veiculos = new List<string>();
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void MostraTotalFaturamento(){
             Console.WriteLine($"Total do faturamento do estacionamento: {this.totalFaturamento}");
        }

        public void AdicionarVeiculo()
        {
            // Pede para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
             this.veiculos.Add( Console.ReadLine());
             this.totalVeiculosJaEstacionados++;
        }
        public void ListarVeiculosJaCadastrados(){
            // Lista quantidade de veículos já cadastrados no estacionamento
             Console.WriteLine($"Já passaram {this.totalVeiculosJaEstacionados} veículos pelo estacionamento");

        }
        public void RemoverVeiculo()
        {
            // Pede para o usuário digitar a placa e armazenar na variável placa
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if ( this.veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
               int horas = 0;   
               decimal valorTotal = 0; 
                // Pede para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = Convert.ToInt32(Console.ReadLine());

                // Realiza o cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                valorTotal = this.precoInicial + this.precoPorHora * (horas-1);
                this.totalFaturamento = valorTotal + this.totalFaturamento;
                // Remove a placa digitada da lista de veículos
                this.veiculos.Remove(placa);

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
                // Realiza laço de repetição, exibindo os veículos estacionados
                Console.WriteLine("Os veículos estacionados são:");
                foreach(String valor in veiculos){
                    Console.WriteLine($"Veículo: {valor}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
