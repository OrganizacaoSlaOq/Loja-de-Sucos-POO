public class Pessoa
{
    private static int UltimoId = 0;

    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public DateTime DataNascimento { get; set; }
    public Telefone Telefone { get; set; }
    public Endereco Endereco { get; set; }

    public Pessoa(string nome, string cpf, string email, DateTime dataNascimento, Telefone telefone, Endereco endereco)
    {
        UltimoId++;
        Id = UltimoId;
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
            $"ID: {Id}\n" +
            $"Nome: {Nome}\n" +
            $"CPF: {Cpf}\n" +
            $"Email: {Email}\n" +
            $"Data de Nascimento: {DataNascimento}\n" +
            $"Telefone: {Telefone}\n" +
            $"Endereço: {Endereco}\n";
    }
}
