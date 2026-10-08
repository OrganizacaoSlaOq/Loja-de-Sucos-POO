public class Pessoa
{
    public string Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public DateTime DataNascimento { get; set; }
    public Telefone Telefone { get; set; }
    public Endereco Endereco { get; set; }

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
