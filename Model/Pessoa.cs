public class Pessoa
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public DateTime DataNascimento { get; set; }
    public Telefone Telefone { get; set; }
    public Endereco Endereco { get; set; }

    public Pessoa()
    {
    }

    public Pessoa(int id, string nome, string cpf, string email, DateTime dataNascimento, Telefone telefone, Endereco endereco)
    {
        Id = id;
        Nome = nome;
        Cpf = cpf;
        Email = email;
        DataNascimento = dataNascimento;
        Telefone = telefone;
        Endereco = endereco;
    }

    public override string ToString()
    {
        return
            $"Nome: {Nome}\n" +
            $"CPF: {Cpf}\n" +
            $"Email: {Email}\n" +
            $"Data de Nascimento: {DataNascimento}\n" +
            $"Telefone: {Telefone}\n" +
            $"Endereço: {Endereco}\n";
    }
}
