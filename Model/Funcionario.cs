public class Funcionario : Pessoa
{
        public string Cargo { get; set; }
        public decimal Salario { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(int id, string nome, string cpf, string email, DateTime dataNascimento, Telefone telefone, Endereco endereco, string cargo, decimal salario) : base(id, nome, cpf, email, dataNascimento, telefone, endereco)
        {
            Cargo = cargo;
            Salario = salario;
        }

        public override string ToString()
        {
            return $"----------Dados Do Funcionário----------\n" +
                   $"{base.ToString()}" +
                   $"Cargo: {Cargo}" +
                   $"Salaário {Salario:C2}";
        }
}
