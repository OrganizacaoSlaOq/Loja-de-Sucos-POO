public class Telefone
{
    public string Numero { get; set; }
    public string Ddd  { get; set; }
    public string Operadora { get; set; }

    public override string ToString()
    {
        return $"({Ddd}) {Numero},\n" +
               $" {nameof(Operadora)}: {Operadora}";
    }
}
