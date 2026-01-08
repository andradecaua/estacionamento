
namespace estacionamento.Models
{
    class Estacionamento
    {
        public decimal PrecoInicial {get; set;} = 0;
        public decimal PrecoPorHora {get; set;} = 0;

        public List<string> VeiculosEstacionados {get; set;} = new List<string>();

        public void CadastrarVeiculo(string placa)
        {
            if (String.IsNullOrEmpty(placa))
            {
                Console.WriteLine("Placa inválida");
            }
            else if(VeiculosEstacionados.IndexOf(placa) == -1)
            {   
                VeiculosEstacionados.Add(placa);
                Console.WriteLine("Veículo Adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("Veículo já está cadastrado!");
            }            
        }

        public void RemoverVeiculo(string placa)
        {
            if (String.IsNullOrEmpty(placa))
            {
                Console.WriteLine("Placa inválida");
            }
            else if(VeiculosEstacionados.IndexOf(placa) == -1)
            {
                Console.WriteLine("Esse veículo não está estacionado");
            }
            else
            {
                Console.WriteLine("Quantas horas ficou estacionado?: ");
                string inputHoras = Console.ReadLine();
                decimal horas;
                decimal.TryParse(inputHoras, out horas);
                VeiculosEstacionados.Remove(placa);
                Console.WriteLine("O veículo foi removido com sucesso!");
                CalcularValorTotal(horas);
            }
        }

        public void CalcularValorTotal(decimal tempoEstacionado)
        {   
            decimal valorTotal = PrecoInicial + (PrecoPorHora * tempoEstacionado);
            Console.WriteLine($"O valor total foi de R${valorTotal}");
        }

        public void ListarVeiculosEstacionados()
        {
            Console.WriteLine("Exibindo veículos estacionados: \n");
            int posicaoEstacionado = 1;
            foreach(string carro in VeiculosEstacionados)
            {
                Console.WriteLine($"{posicaoEstacionado} - {carro}");
            }
        }

    }
}