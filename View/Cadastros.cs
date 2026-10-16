public class Cadastros
{
    public Cliente CadastroCliente()
    {
        Cliente cliente = new Cliente();

        Console.WriteLine("--------------Cadastro De Cliente---------------");
        Console.Write("Nome: ");
        cliente.Nome = Console.ReadLine();
        Console.Write("CPF: ");
        cliente.Cpf = Console.ReadLine();
        Console.Write("Email: ");
        cliente.Email = Console.ReadLine();
        Console.Write("Data de Nascimento: ");
        string dataInformada = Console.ReadLine();
        if (DateTime.TryParse(dataInformada, out DateTime data))
        {
            cliente.DataNascimento = data;
        }
        else
        {
            Console.WriteLine("Erro na data");
        }

        Console.Write("Telefone: ");
        cliente.Telefone = CadastroTelefone();
        Console.WriteLine("Endereco: ");
        cliente.Endereco = CadastrarEndereco();
        return cliente;
    }
    
    public Funcionario CadastroFuncionario()
    {
        Funcionario funcionario = new Funcionario();

        Console.WriteLine("--------------Cadastro De Funcionário---------------");
        Console.Write("Nome: ");
        funcionario.Nome = Console.ReadLine();
        Console.Write("CPF: ");
        funcionario.Cpf = Console.ReadLine();
        Console.Write("Email: ");
        funcionario.Email = Console.ReadLine();
        Console.Write("Data de Nascimento: ");
        string dataInformada = Console.ReadLine();
        if (DateTime.TryParse(dataInformada, out DateTime data))
        {
            funcionario.DataNascimento = data;
        }
        else
        {
            Console.WriteLine("Erro na data");
        }
        Console.Write("Cargo: ");
        funcionario.Cargo = Console.ReadLine();
        Console.Write("Salario: ");
        funcionario.Salario = Convert.ToDecimal(Console.ReadLine());
        
        Console.Write("Telefone: ");
        funcionario.Telefone = CadastroTelefone();
        Console.WriteLine("Endereco: ");
        funcionario.Endereco = CadastrarEndereco();
        return funcionario;
    }
    
    public Telefone CadastroTelefone()
    {
        Telefone telefone = new Telefone();

        Console.WriteLine("---------------Cadastro de Telefone---------------");

        Console.WriteLine("Numero: ");
        telefone.Numero = Console.ReadLine();
        Console.WriteLine("DDD: ");
        telefone.Ddd = Console.ReadLine();
        Console.WriteLine("Operadora: ");
        telefone.Operadora = Console.ReadLine();
        
        return telefone;
    }
    
    public Endereco CadastrarEndereco()
    {
        Endereco endereco = new Endereco();
     
        Console.WriteLine("---------------Cadastro de Endereço---------------");
        Console.Write("Logradouro: ");
        endereco.Logradouro = Console.ReadLine();
        Console.Write("Bairro: ");
        endereco.Bairro = Console.ReadLine();
        Console.Write("Cep: ");
        endereco.Cep = Console.ReadLine();
        Console.Clear();
        Console.Write("Cidade...:");
        endereco.Cidade = Console.ReadLine();
        Console.Clear();
        Console.Write("Estado...:");
        endereco.Uf = Console.ReadLine();
        return endereco;
    }

    public Suco SucoCadastro()
    {
        Suco suco = new Suco();

        Console.WriteLine("---------------Cadastro De Suco---------------");
        
        Console.Write("Nome: ");
        suco.NomeSuco = Console.ReadLine();
        Console.Write("Descrição: ");
        suco.Descricao = Console.ReadLine();
        Console.Write("Preço: ");
        suco.Preco = Convert.ToDecimal(Console.ReadLine());
        
        return suco;
    }
}
