using System;

namespace YourNamespace
{
    public class MateriaPrima
    {
       
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Quantidade { get; set; }
        public string UnidadeMedida { get; set; }
        public decimal PrecoPorUnidade { get; set; }

        
        public MateriaPrima(int id, string nome, double quantidade, string unidadeMedida, decimal precoPorUnidade)
        {
            Id = id;
            Nome = nome;
            Quantidade = quantidade;
            UnidadeMedida = unidadeMedida;
            PrecoPorUnidade = precoPorUnidade;
        }

        
        public decimal CalcularCustoTotal()
        {
            return PrecoPorUnidade * (decimal)Quantidade;
        }

       
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Quantidade: {Quantidade} {UnidadeMedida}");
            Console.WriteLine($"Preço por Unidade: {PrecoPorUnidade:C}");
            Console.WriteLine($"Custo Total: {CalcularCustoTotal():C}");
        }
    }
}