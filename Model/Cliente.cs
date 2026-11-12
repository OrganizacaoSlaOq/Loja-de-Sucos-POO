public class Cliente : Pessoa
{
    public Cliente()
    {
    }

    public Cliente(int id, string nome, string cpf, string email, DateTime dataNascimento, Telefone telefone, Endereco endereco) : base(id, nome, cpf, email, dataNascimento, telefone, endereco)
    {
    }

    public override string ToString()
    {
            return $"----------Dados Do Cliente----------\n" +
                   $"{base.ToString()}";
    }
}
