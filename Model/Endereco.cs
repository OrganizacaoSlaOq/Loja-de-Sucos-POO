
public class Endereco
{
  
    public string Logradouro { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Cep { get; set; }
    public string Uf { get; set; }

    public override string ToString()
    {
        return
            $" Logradouro: {Logradouro}, Bairro: {Bairro}, Cidade: {Cidade}, CEP: {Cep}, Estado: {Uf}";
    }
}
