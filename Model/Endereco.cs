public class Endereco
{
    private static int UltimoId = 0;
    
    public int Id { get; set; }
    public string Logradouro { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Cep { get; set; }
    public string Uf { get; set; }

    public Endereco(string logradouro, string bairro, string cidade, string cep, string uf)
    {
        UltimoId++;
        Id = UltimoId;
        Logradouro = logradouro;
        Bairro = bairro;
        Cidade = cidade;
        Cep = cep;
        Uf = uf;
    }

    public override string ToString()
    {
        return
            $"----------Dados do Endereco----------\n" +
            $"{nameof(Id)}: {Id}\n" +
            $"{nameof(Logradouro)}: {Logradouro}\n" +
            $"{nameof(Bairro)}: {Bairro}" +
            $"{nameof(Cidade)}: {Cidade}\n" +
            $"{nameof(Cep)}: {Cep}\n" +
            $"{nameof(Uf)}: {Uf}";
    }
}
