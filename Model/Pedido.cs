public class Pedido
{
        public string Id { get; set; }
        public Cliente Cliente { get; set; }
        public Funcionario Atendente { get; set; }
        public Suco Suco { get; set; }
        public string Extras { get; set; }
        public decimal Preco {get; set;}
    
        
        public override string ToString()
        {
            return
                $"----------Dados do Pedido----------\n" +
                $"{nameof(Id)}: {Id}\n" +
                $"{nameof(Cliente)}: {Cliente.Id}\n" +
                $"{nameof(Cliente)}: {Cliente.Nome}\n" +
                $"{nameof(Atendente)}: {Atendente.Id}\n" +
                $"{nameof(Atendente)}: {Atendente.Nome}\n" +
                $"{nameof(Suco)}: {Suco.NomeSuco}\n" +
                $"{nameof(Preco)}: {Preco:C2}";
        }

        public void CalcularPrecoTotal(decimal precoSuco, string precoExtra)
        {
            decimal precoExtra_ = 0;
            try
            {
                precoExtra_ = Convert.ToDecimal(precoExtra);
            }
            catch (FormatException)
            {
                Console.WriteLine("Não foi possível converter em decimal, a formatação está incorreta, tente novamente.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Não foi possível converter em decimal, O número é grande demais para converter, tente novamente.");
            }
            
            decimal precoTotal = precoSuco + precoExtra_;
            
            Preco = precoTotal;
        }
}
