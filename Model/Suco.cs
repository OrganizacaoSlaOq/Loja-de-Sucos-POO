public class Suco
{
    public string Id { get; set; }
    public string NomeSuco { get; set; }
    public string Descricao { get; set; }
    public decimal Preco { get; set; }
    public string Adicionais { get; set; }

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
