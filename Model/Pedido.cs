public class Pedido
{
    public string Id { get; set; }
    public Cliente Cliente { get; set; }
    public Atendente Atendente { get; set; }
    public Suco Suco { get; set; }
    public decimal Preco {get; set;}


    public override string ToString()
    {
        return
            $"----------Dados do Pedido----------" +
            $"{nameof(Id)}: {Id}\n" +
            $"{nameof(Cliente)}: {Cliente}\n" +
            $"{nameof(Atendente)}: {Atendente}\n" +
            $"{nameof(Suco)}: {Suco}\n" +
            $"{nameof(Preco)}: {Preco:C2}";
    }
}
