public class Suco
{
    public int Id { get; set; }
    public string NomeSuco { get; set; }
    public string Descricao { get; set; }
    public decimal Preco { get; set; }
    public string Adicionais { get; set; }

    public Suco()
    {
    }

    public Suco(int id, string nomeSuco, string descricao, decimal preco, string adicionais)
    {
        Id = id;
        NomeSuco = nomeSuco;
        Descricao = descricao;
        Preco = preco;
        Adicionais = adicionais;
    }

    public override string ToString()
        {
            return $"----------Dados do Suco---------\n" +
                   $"Id: {Id}\n" +
                   $"NomeSuco: {NomeSuco}\n" +
                   $"Descricao: {Descricao}\n" +
                   $"Preco: {Preco:C2}\n" +
                   $"Adicionais: {Adicionais}";
        }
}
