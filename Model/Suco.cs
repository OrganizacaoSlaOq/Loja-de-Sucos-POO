public class Suco
{
    private static int UltimoId = 0; 
    
    public int Id { get; set; }
    public string NomeSuco { get; set; }
    public string Descricao { get; set; }
    public decimal Preco { get; set; }
    public string Adicionais { get; set; }

    public Suco(string id, string nomeSuco, string descricao, decimal preco, string adicionais)
    {
        UltimoId++;
        Id = UltimoId;
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
