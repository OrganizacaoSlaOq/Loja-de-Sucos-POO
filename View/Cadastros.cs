public class Cadastros
{
    private bool genericBool = false; //Serve tanto pra ver se tem registro, e também pra whiles no geral
    private string resposta;
    
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

        do
        {
            Console.Write("Data de Nascimento: ");
            string dataInformada = Console.ReadLine();
        
            if (DateTime.TryParse(dataInformada, out DateTime data))
            {
                cliente.DataNascimento = data;
                genericBool = true;
            }
            else
            {
                Console.WriteLine("Erro na data");
                genericBool = false;
            }
        } while (!genericBool);

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
        do
        {
            Console.Write("Data de Nascimento: ");
            string dataInformada = Console.ReadLine();
        
            if (DateTime.TryParse(dataInformada, out DateTime data))
            {
                funcionario.DataNascimento = data;
                genericBool = true;
            }
            else
            {
                Console.WriteLine("Erro na data");
                genericBool = false;
            }
        } while (!genericBool);
        
        Console.Write("Cargo: ");
        funcionario.Cargo = Console.ReadLine();
        do
        {
            Console.Write("Salário: ");
            resposta = Console.ReadLine();
            try
            {
                funcionario.Salario = Convert.ToDecimal(resposta);
                resposta = "";
                genericBool = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                resposta = "";
                genericBool = false;
                throw;
            }

        }while(!genericBool);

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
        Console.Write("Cidade:");
        endereco.Cidade = Console.ReadLine();
        Console.Clear();
        Console.Write("Estado:");
        endereco.Uf = Console.ReadLine();
        return endereco;
    }

    public Suco CadastrarSuco()
    {
        Suco suco = new Suco();

        Console.WriteLine("---------------Cadastro De Suco---------------");
        
        Console.Write("Nome: ");
        suco.NomeSuco = Console.ReadLine();
        Console.Write("Descrição: ");
        suco.Descricao = Console.ReadLine();
        do
        {
            Console.Write("Preço: ");
            resposta = Console.ReadLine();
            try
            {
                suco.Preco = Convert.ToDecimal(resposta);
                resposta = "";
                genericBool = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                resposta = "";
                genericBool = false;
                throw;
            }

        }while(!genericBool);
        
        return suco;
    }
    public Pedido PedidoCadastro(GenericRepository<Cliente> clientes,  GenericRepository<Funcionario> atendentes, GenericRepository<Suco> sucos)
    {
        
        Pedido pedido = new Pedido();
        
        Console.WriteLine("--------------- Cadastro de Pedido ---------------");
        Console.WriteLine("\n");
        
        decimal precoExtra = 0;
        
        do
        {
            Console.Write("Nome do Cliente que realizou o pedido: ");
            resposta = Console.ReadLine();
            foreach (Cliente cliente in clientes.GetAll())
            {
                if (cliente.Nome == resposta)
                {
                    pedido.Cliente = cliente;
                    genericBool = true;
                    resposta = "";
                }
                else
                {
                    Console.WriteLine("Registro não encontrado");
                    genericBool = false;
                    resposta = "";
                }
            }
        } while (!genericBool);
        
        do
        {
            Console.WriteLine("\n");
            Console.Write("Nome do Suco pedido:");
            resposta = Console.ReadLine();
            foreach (Suco suco in sucos.GetAll())
            {
                if (suco.NomeSuco == resposta)
                {
                    pedido.Suco = suco;
                    genericBool = true;
                    resposta = "";
                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Registro não encontrado");
                    Console.WriteLine("Tecle qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                    genericBool = false;
                    resposta = "";
                    Console.Clear();
                }
            }
        } while (!genericBool);

        do
        {
            Console.WriteLine("\n");
            Console.WriteLine("Tem algum adicional?");
            Console.WriteLine("1) Sim");
            Console.WriteLine("2) Não");
            resposta = Console.ReadLine();
            switch (resposta)
            {
                case "1":
                    pedido.Adicional = resposta;
                    resposta = "";
                    Console.WriteLine("\n");
                    Console.WriteLine("Insira o preço do adicional");
                    precoExtra = Convert.ToDecimal(Console.ReadLine());
                    genericBool = true;
                    break;
                case "2":
                    Console.WriteLine("\n");
                    pedido.Adicional = "Sem adicional";
                    resposta = "";
                    precoExtra = 0;
                    genericBool = true;
                    break;
                default:
                    Console.WriteLine("\n");
                    Console.WriteLine("Opção não disponível");
                    Console.WriteLine("Tecle qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                    genericBool = false;
                    Console.Clear();
                    break;
            }
        } while (!genericBool);

        Console.WriteLine("\n");
        pedido.Preco = pedido.CalcularPrecoTotal(precoExtra);
        Console.Write($"O preço total é de: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(pedido.Preco);
        Console.ResetColor();
        
        Console.WriteLine("\n");
        Console.WriteLine("Pedido Realizado Com Sucesso!!!");
        Console.WriteLine("Tecle qualquer tecla para retornar ao menu.");
        Console.ReadKey();
        Console.Clear();
        
        return pedido;
    }
}
