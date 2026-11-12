public class Cadastros
{

    public Cliente CadastroCliente(GenericController<Cliente> clienteController, GenericController<Telefone> telefoneController, GenericController<Endereco> enderecoController)
    {
        bool genericBool = false; //Serve tanto pra ver se tem registro, e também pra whiles no geral

        Cliente cliente = new Cliente();

        if (clienteController.MimDePapai().Any())
        {
            cliente.Id = clienteController.MimDePapai().Last().Id + 1;
        }
        else
        {
            cliente.Id = 1;
        }
        
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
                genericBool = false;
            }
            else
            {
                Console.WriteLine("Erro na data");
                genericBool = true;
            }
        } while (genericBool);

        Console.Write("Telefone: ");
        cliente.Telefone = CadastroTelefone(telefoneController);
        Console.WriteLine("Endereco: ");
        cliente.Endereco = CadastroEndereco(enderecoController);
        return cliente;
    }

    public Funcionario CadastroFuncionario(GenericController<Funcionario> funcionarioController, GenericController<Telefone> telefoneController, GenericController<Endereco> enderecoController)
    {
        bool genericBool = false; //Serve tanto pra ver se tem registro, e também pra whiles no geral

        Funcionario funcionario = new Funcionario();

        Console.WriteLine("--------------Cadastro De Funcionário---------------");
        
        if (funcionarioController.MimDePapai().Any())
        {
            funcionario.Id = funcionarioController.MimDePapai().Last().Id + 1;
        }
        else
        {
            funcionario.Id = 1;
        }
        
        Console.Write("Nome: ");
        funcionario.Nome = Console.ReadLine();
        Console.Write("CPF: ");
        funcionario.Cpf = Console.ReadLine();
        Console.Write("Email: ");
        funcionario.Email = Console.ReadLine();
        do
        {
            Console.Write("Data de Nascimento: ");
            string dataInformada = Console.ReadLine();
            if (DateTime.TryParse(dataInformada, out DateTime data))
            {
                funcionario.DataNascimento = data;
                genericBool = false;
            }
            else
            {
                Console.WriteLine("Erro na data");
                genericBool = true;
            }
        } while (genericBool);

        Console.Write("Cargo: ");
        funcionario.Cargo = Console.ReadLine();
        Console.Write("Salario: ");
        funcionario.Salario = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Telefone: ");
        funcionario.Telefone = CadastroTelefone(telefoneController);
        Console.WriteLine("Endereco: ");
        funcionario.Endereco = CadastroEndereco(enderecoController);
        return funcionario;
    }

    public Telefone CadastroTelefone(GenericController<Telefone> telefoneController)
    {
        Telefone telefone = new Telefone();

        Console.WriteLine("---------------Cadastro de Telefone---------------");

        bool genericBool = false; //Serve tanto pra ver se tem registro, e também pra whiles no geral
        
        if (telefoneController.MimDePapai().Any())
        {
            telefone.Id = telefoneController.MimDePapai().Last().Id + 1;
        }
        else
        {
            telefone.Id = 1;
        }
        
        Console.WriteLine("Numero: ");
        telefone.Numero = Console.ReadLine();
        Console.WriteLine("DDD: ");
        telefone.Ddd = Console.ReadLine();
        Console.WriteLine("Operadora: ");
        telefone.Operadora = Console.ReadLine();

        return telefone;
    }

    public Endereco CadastroEndereco(GenericController<Endereco> enderecoController)
    {
        Endereco endereco = new Endereco();

        if (enderecoController.MimDePapai().Any())
        {
            endereco.Id = enderecoController.MimDePapai().Last().Id + 1;
        }
        else
        {
            endereco.Id = 1;
        }
        
        Console.WriteLine("---------------Cadastro de Endereço---------------");
        Console.Write("Logradouro: ");
        endereco.Logradouro = Console.ReadLine();
        Console.Write("Bairro: ");
        endereco.Bairro = Console.ReadLine();
        Console.Write("Cep: ");
        endereco.Cep = Console.ReadLine();
        Console.Write("Cidade...:");
        endereco.Cidade = Console.ReadLine();
        Console.Write("Estado...:");
        endereco.Uf = Console.ReadLine();
        return endereco;
    }

    public Suco CadastroSuco(GenericController<Suco> sucoController)
    {
        Suco suco = new Suco();

        Console.WriteLine("---------------Cadastro De Suco---------------");

        if (sucoController.MimDePapai().Any())
        {
            suco.Id = sucoController.MimDePapai().Last().Id + 1;
        }
        else
        {
            suco.Id = 1;
        }
        
        Console.Write("Nome: ");
        suco.NomeSuco = Console.ReadLine();
        Console.Write("Descrição: ");
        suco.Descricao = Console.ReadLine();
        Console.Write("Preço: ");
        suco.Preco = Convert.ToDecimal(Console.ReadLine());

        return suco;
    }


    public Pedido CadastroPedido(GenericController<Pedido> pedidoController, GenericController<Cliente> clientes, GenericController<Funcionario> atendentes,
        GenericController<Suco> sucos)
    {

        Pedido pedido = new Pedido();

        Console.WriteLine("--------------- Cadastro de Pedido ---------------");
        Console.WriteLine("\n");

        if (pedidoController.MimDePapai().Any())
        {
            pedido.Id = pedidoController.MimDePapai().Last().Id + 1;
        }
        else
        {
            pedido.Id = 1;
        }
        
        bool genericBool = false; //Serve tanto pra ver se tem registro, e também pra whiles no geral
        string resposta;
        decimal precoExtra = 0;
        do
        {
            Console.Write("ID do Cliente que realizou o pedido: ");

            foreach (Cliente cliente in clientes.MimDePapai())
            {
                Console.WriteLine($"{cliente.Id}. {cliente.Nome}");
            }

            resposta = Console.ReadLine();

            foreach (Cliente cliente in clientes.MimDePapai())
            {
                if (cliente.Id.ToString() == resposta)
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
            Console.Write("ID do Atendente que realizou o pedido: ");
            resposta = Console.ReadLine();
            foreach (Funcionario atendente in atendentes.MimDePapai())
            {
                Console.WriteLine($"{atendente.Id}. {atendente.Nome}");
            }

            resposta = Console.ReadLine();

            foreach (Funcionario atendente in atendentes.MimDePapai())
            {
                if (atendente.Id.ToString() == resposta)
                {
                    pedido.Atendente = atendente;
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
            Console.Write("ID do Suco que realizou o pedido: ");
            resposta = Console.ReadLine();
            foreach (Suco suco in sucos.MimDePapai())
            {
                Console.WriteLine($"{suco.Id}. {suco.NomeSuco}");
            }

            resposta = Console.ReadLine();

            foreach (Suco suco in sucos.MimDePapai())
            {
                if (suco.Id.ToString() == resposta)
                {
                    pedido.Suco = suco;
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
            Console.WriteLine("Tem algum adicional?");
            Console.WriteLine("1) Sim");
            Console.WriteLine("2) Não");
            resposta = Console.ReadLine();
            switch (resposta)
            {
                case "1":
                    pedido.Extras = resposta;
                    resposta = "";
                    Console.WriteLine("Insira o preço do adicional");
                    precoExtra = Convert.ToDecimal(Console.ReadLine());
                    genericBool = true;
                    break;
                case "2":
                    pedido.Extras = "Sem adicional";
                    resposta = "";
                    precoExtra = 0;
                    genericBool = true;
                    break;
                default:
                    Console.WriteLine("Opção não disponível");
                    genericBool = false;
                    break;
            }
        } while (!genericBool);

        Console.WriteLine("\n");
        pedido.Preco = pedido.CalcularPrecoTotal(precoExtra);
        Console.Write($"O preço total é de: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(pedido.Preco);
        Console.ResetColor();

        Console.WriteLine("Pedido Realizado Com Sucesso!");
        Console.WriteLine("Tecle qualquer tecla para retornar ao menu.");

        return pedido;
    }
}
