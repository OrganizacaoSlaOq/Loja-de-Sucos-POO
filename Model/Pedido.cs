public class Pedido
{
    private static int UltimoId = 0;
    public int Id { get; set; }
    public Cliente Cliente { get; set; }
    public Funcionario Atendente { get; set; }
    public Suco Suco { get; set; }
    public string Adicional { get; set; }
    public decimal Preco {get; set;}

    public Pedido(Cliente cliente, Funcionario atendente, Suco suco, string adicional, decimal preco)
    {
        UltimoId++;
        Id = UltimoId;
        Cliente = cliente;
        Atendente = atendente;
        Suco = suco;
        Adicional = adicional;
        Preco = preco;
    }

    public override string ToString()
    {
        return
            $"----------Dados do Pedido----------\n" +
            $"{nameof(Id)}: {Id}\n" +
            $"{nameof(Cliente)}: {Cliente.Id}\n" +
            $"{nameof(Cliente)}: {Cliente.Nome}\n" +
            $"{nameof(Atendente)}: {Atendente.Id}\n" +
            $"{nameof(Atendente)}: {Atendente.Nome}\n" +
            $"{nameof(Adicional)}: {Adicional}\n" +
            $"{nameof(Suco)}: {Suco.NomeSuco}\n" +
            $"{nameof(Preco)}: {Preco:C2}";
    }

       public decimal CalcularPrecoTotal(decimal precoExtra)
    { 
        decimal precoSuco = Suco.Preco;
        
        decimal precoTotal = precoSuco + precoExtra;
            
        Preco = precoTotal;
        
        return precoTotal;
    }
}
