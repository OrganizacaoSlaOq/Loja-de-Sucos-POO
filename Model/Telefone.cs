public class Telefone
{
    public int Id { get; set; } 
    public string Numero { get; set; }
    public string Ddd { get; set; }
    public string Operadora { get; set; }

    public Telefone()
    {
    }

    public Telefone(int id, string numero, string ddd, string operadora)
    {
        Id = id;
        Numero = numero;
        Ddd = ddd;
        Operadora = operadora;
    }

    public override string ToString()
    {
        return $"{nameof(Id)}: {Id}" +
               $"({Ddd}) {Numero},\n" +
               $" {nameof(Operadora)}: {Operadora}";
    }
}
