public class Telefone
{
    private static int UltimoId = 0;
    public int Id { get; set; } 
    public string Numero { get; set; }
    public string Ddd { get; set; }
    public string Operadora { get; set; }

    public Telefone(string numero, string ddd, string operadora)
    {
        UltimoId++;
        Id = UltimoId;
        Numero = numero;
        Ddd = ddd;
        Operadora = operadora;
    }

    public override string ToString()
    {
        return $"{nameof(Id)}: {Operadora}" +
               $"({Ddd}) {Numero},\n" +
               $" {nameof(Operadora)}: {Operadora}";
    }
}
