public class Endereco
{
    public int Id { get; set; }
    public string Logradouro { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Cep { get; set; }
    public string Uf { get; set; }

    public Endereco()
    {
    }

    public Endereco(int id, string logradouro, string bairro, string cidade, string cep, string uf)
    {
        Id = id;
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
            $"{nameof(Bairro)}: {Bairro}\n" +
            $"{nameof(Cidade)}: {Cidade}\n" +
            $"{nameof(Cep)}: {Cep}\n" +
            $"{nameof(Uf)}: {Uf}";
    }
}
