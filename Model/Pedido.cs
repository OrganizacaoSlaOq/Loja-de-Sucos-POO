public class Pedido
{
    public int Id { get; set; }
    public Cliente Cliente { get; set; }
    public Funcionario Atendente { get; set; }
    public Suco Suco { get; set; }
    public string Extras { get; set; }
    public decimal Preco {get; set;}

    public Pedido()
    {
    }

    public Pedido(int id, Cliente cliente, Funcionario atendente, Suco suco, string extras, decimal preco)
    {
        Id = id;
        Cliente = cliente;
        Atendente = atendente;
        Suco = suco;
        Extras = extras;
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
