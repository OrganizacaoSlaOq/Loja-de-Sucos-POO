using static System.Console;
public class Menu
{
    
    public void MenuCadastrar(GenericController<Cliente> clienteController,
        GenericController<Funcionario> funcionarioController, GenericController<Suco> sucoController,
        GenericController<Pedido> pedidoController, GenericController<Endereco> enderecoController,
        GenericController<Telefone> telefoneController)
    {
        Cadastros cadastros = new Cadastros();

        string opc;
        do
        {
            Console.WriteLine("Escolha algo para cadastrar\n");
            Console.WriteLine("1 - Cliente");
            Console.WriteLine("2 - Funcionário");
            Console.WriteLine("3 - Suco");
            Console.WriteLine("4 - Pedido");
            Console.WriteLine("5 - Endereco");
            Console.WriteLine("6 - Telefone");
            Console.WriteLine("0 - Voltar ao menu principal");

            Console.Write("\n>>> ");
            opc = Console.ReadLine();
            Console.Clear();
                switch (opc)
                {
                    case "1":
                        clienteController.Cadastrar(cadastros.CadastroCliente(clienteController, telefoneController, enderecoController));
                        break;
                    
                    case "2":
                        funcionarioController.Cadastrar(cadastros.CadastroFuncionario(funcionarioController, telefoneController, enderecoController));
                        break;

                    case "3":
                        sucoController.Cadastrar(cadastros.CadastroSuco(sucoController));
                        break;

                    case "4":
                        pedidoController.Cadastrar(cadastros.CadastroPedido(pedidoController,clienteController, funcionarioController,sucoController));
                        break;
                    case "5":
                        enderecoController.Cadastrar(cadastros.CadastroEndereco(enderecoController));
                        break;
                    case "6":
                        telefoneController.Cadastrar(cadastros.CadastroTelefone(telefoneController));
                        break;

                    case "0":
                        Console.WriteLine("Tecle qualquer tecla pra voltar.");
                        Console.ReadKey();
                        Console.Clear();
                        return;

                    default:
                        Console.Write("Opção inválida, tecle qualquer tecla para tentar novamente...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
        } while (opc != "0");
    }
    
    
    public void MenuDeletar(GenericController<Cliente> clienteController,
        GenericController<Funcionario> funcionarioController, GenericController<Suco> sucoController,
        GenericController<Pedido> pedidoController, GenericController<Endereco> enderecoController,
        GenericController<Telefone> telefoneController)
    {
        Deletar deletar = new Deletar();
    
        string opc;
        do
        {
            Console.WriteLine("Escolha algo para Deletar\n");
            Console.WriteLine("1 - Cliente");
            Console.WriteLine("2 - Funcionário");
            Console.WriteLine("3 - Suco");
            Console.WriteLine("4 - Pedido");
            Console.WriteLine("5 - Endereco");
            Console.WriteLine("6 - Telefone");
            Console.WriteLine("0 - Voltar ao menu principal");

            Console.Write("\n>>> ");
            opc = Console.ReadLine();
            Console.Clear();

                switch (opc)
                {
                    case "1":
                        if (clienteController.MimDePapai().Any())
                        {
                            deletar.DeletarCliente(clienteController);
                        }
                        else
                        {
                            Console.WriteLine("Sem Cadastros de Cliente");
                            Console.WriteLine("Tecle qualquer tecla pra voltar.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    
                    case "2":
                        if (funcionarioController.MimDePapai().Any())
                        {
                            deletar.DeletarFuncionario(funcionarioController);
                        }
                        else
                        {
                            Console.WriteLine("Sem Cadastros de Funcinário");
                            Console.WriteLine("Tecle qualquer tecla pra voltar.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case "3":
                        if (sucoController.MimDePapai().Any())
                        {
                            deletar.DeletarSuco(sucoController);
                        }
                        else
                        {
                            Console.WriteLine("Sem Cadastros de Suco");
                            Console.WriteLine("Tecle qualquer tecla pra voltar.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case "4":
                        if (pedidoController.MimDePapai().Any())
                        {
                            deletar.DeletarPedido(pedidoController);
                        }
                        else
                        {
                            Console.WriteLine("Sem Cadastros de Pedido");
                            Console.WriteLine("Tecle qualquer tecla pra voltar.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case "5":
                        if (enderecoController.MimDePapai().Any())
                        {
                            deletar.DeletarEndereco(enderecoController);
                        }
                        else
                        {
                            Console.WriteLine("Sem Cadastros de Endereço");
                            Console.WriteLine("Tecle qualquer tecla pra voltar.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case "6":
                        if (telefoneController.MimDePapai().Any())
                        {
                            deletar.DeletarTelefone(telefoneController);
                        }
                        else
                        {
                            Console.WriteLine("Sem Cadastros de Telefone");
                            Console.WriteLine("Tecle qualquer tecla pra voltar.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;


                    case "0":
                        Console.WriteLine("Tecle qualquer tecla pra voltar.");
                        Console.ReadKey();
                        Console.Clear();
                        return;

                    default:
                        Console.Write("Opção inválida, tecle qualquer tecla para tentar novamente...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
        } while (opc != "0");
    }
    public void MenuVisualizar(GenericController<Cliente> clienteController,
        GenericController<Funcionario> funcionarioController, GenericController<Suco> sucoController,
        GenericController<Pedido> pedidoController, GenericController<Endereco> enderecoController,
        GenericController<Telefone> telefoneController)
    {
        Visualizar visualizar = new Visualizar();
    
        string opc;
        do
        {
            Console.WriteLine("Escolha algo para visualizar\n");
            Console.WriteLine("1 - Cliente");
            Console.WriteLine("2 - Funcionário");
            Console.WriteLine("3 - Suco");
            Console.WriteLine("4 - Pedido");
            Console.WriteLine("5 - Endereco");
            Console.WriteLine("6 - Telefone");
            Console.WriteLine("0 - Voltar ao menu principal");

            Console.Write("\n>>> ");
            opc = Console.ReadLine();
            Console.Clear();

                switch (opc)
                {
                    case "1":
                        if (clienteController.MimDePapai().Any())
                        {
                            visualizar.VisualizarCliente(clienteController);
                        }
                        else
                        {
                            Console.WriteLine("Sem Cadastros de Cliente");
                            Console.WriteLine("Tecle qualquer tecla pra voltar.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    
                    case "2":
                        if (funcionarioController.MimDePapai().Any())
                        {
                            visualizar.VisualizarFuncionario(funcionarioController);
                        }
                        else
                        {
                            Console.WriteLine("Sem Cadastros de Funcinário");
                            Console.WriteLine("Tecle qualquer tecla pra voltar.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case "3":
                        if (sucoController.MimDePapai().Any())
                        {
                            visualizar.VisualizarSuco(sucoController);
                        }
                        else
                        {
                            Console.WriteLine("Sem Cadastros de Suco");
                            Console.WriteLine("Tecle qualquer tecla pra voltar.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case "4":
                        if (pedidoController.MimDePapai().Any())
                        {
                            visualizar.VisualizarPedido(pedidoController);
                        }
                        else
                        {
                            Console.WriteLine("Sem Cadastros de Pedido");
                            Console.WriteLine("Tecle qualquer tecla pra voltar.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case "5":
                        if (enderecoController.MimDePapai().Any())
                        {
                            visualizar.VisualizarEndereco(enderecoController);
                        }
                        else
                        {
                            Console.WriteLine("Sem Cadastros de Endereço");
                            Console.WriteLine("Tecle qualquer tecla pra voltar.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case "6":
                        if (telefoneController.MimDePapai().Any())
                        {
                            visualizar.VisualizarTelefone(telefoneController);
                        }
                        else
                        {
                            Console.WriteLine("Sem Cadastros de Telefone");
                            Console.WriteLine("Tecle qualquer tecla pra voltar.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case "0":
                        Console.WriteLine("Tecle qualquer tecla pra voltar.");
                        Console.ReadKey();
                        Console.Clear();
                        return;

                    default:
                        Console.Write("Opção inválida, tecle qualquer tecla para tentar novamente...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
        } while (opc != "0");
    }
    public void MenuSalvar(GenericController<Cliente> clienteController,
        GenericController<Funcionario> funcionarioController, GenericController<Suco> sucoController,
        GenericController<Pedido> pedidoController, GenericController<Endereco> enderecoController,
        GenericController<Telefone> telefoneController)
    {
        string opc;
        do
        {
        Console.WriteLine("Escolha algo para Salvar\n");
        Console.WriteLine("1 - Clientes");
        Console.WriteLine("2 - Funcionários");
        Console.WriteLine("3 - Sucos");
        Console.WriteLine("4 - Pedidos");
        Console.WriteLine("5 - Endereco");
        Console.WriteLine("6 - Telefone");
        Console.WriteLine("0 - Voltar ao menu principal");

        Console.Write("\n>>> ");
        opc = Console.ReadLine();
        Console.Clear();
            switch (opc)
            {
                case "1":
                    clienteController.Processar(
                        "clientes.csv",
                        "Id;Nome;Cpf;Email;DataNascimento;IdTelefone;IdEndereco",
                        c=>$"{c.Id};{c.Nome};{c.Cpf};{c.Email};{c.DataNascimento.ToShortDateString()};{c.Telefone.Id};{c.Endereco.Id}"
                        );
                    Console.WriteLine("\nCliente Salvo com sucesso!!!");
                    Console.WriteLine("\nTecle qualquer tecla pra voltar.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                
                case "2":
                    funcionarioController.Processar(
                        "funcionarios.csv",
                        "Id;Nome;Cpf;Email;DataNascimento;IdTelefone;IdEndereco;Cargo;Salario",
                        f=>$"{f.Id};{f.Nome};{f.Cpf};{f.Email};{f.DataNascimento.ToShortDateString()};{f.Telefone.Id};{f.Endereco.Id};{f.Cargo};{f.Salario:C2}"
                    );
                    Console.WriteLine("\nFuncionário Salvo com sucesso!!!");
                    Console.WriteLine("\nTecle qualquer tecla pra voltar.");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case "3":
                    sucoController.Processar(
                        "sucos.csv",
                        "Id;NomeSuco;Descricao;Preco",
                        s => $"{s.Id};{s.NomeSuco};{s.Descricao};{s.Preco:C2}"
                    );
                    Console.WriteLine("\nSuco Salvo com sucesso!!!");
                    Console.WriteLine("\nTecle qualquer tecla pra voltar.");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case "4":
                    pedidoController.Processar(
                        "pedidos.csv",
                        "Id;IdCliente;NomeCliente;IdAtendente;NomeAtendente;IdSuco;NomeSuco;Extras;Preco",
                        p => $"{p.Id};{p.Cliente.Id};{p.Cliente.Nome};{p.Atendente.Id};{p.Atendente.Nome};{p.Suco.Id};{p.Suco.NomeSuco};{p.Extras};{p.Preco:C2}"
                    );
                    Console.WriteLine("\nPedido Salvo com sucesso!!!");
                    Console.WriteLine("\nTecle qualquer tecla pra voltar.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "5":
                    enderecoController.Processar(
                        "enderecos.csv",
                        "Id;Logradouro;Bairro;Cidade;Cep;Uf",
                        e => $"{e.Id};{e.Logradouro};{e.Bairro};{e.Cidade};{e.Cep};{e.Uf}"
                    );
                    Console.WriteLine("\nEndereço Salvo com sucesso!!!");
                    Console.WriteLine("\nTecle qualquer tecla pra voltar.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "6":
                    telefoneController.Processar(
                        "telefone.csv",
                        "Id;DDD;Telefone;Operadora",
                        t => $"{t.Id};{t.Ddd};{t.Numero};{t.Operadora}"
                    );
                    Console.WriteLine("\nTelefone Salvo com sucesso!!!");
                    Console.WriteLine("\nTecle qualquer tecla pra voltar.");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case "0":
                    Console.WriteLine("Tecle qualquer tecla pra voltar.");
                    Console.ReadKey();
                    Console.Clear();
                    return;

                default:
                    Console.Write("Opção inválida, tecle qualquer tecla para tentar novamente...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        } while (opc != "0");
    }
    
    public void TituloAbertura()
        {
            WriteLine("Tecle qualquer tecla para iniciar");
            ReadKey();
            Clear();
            Write("Iniciando");
            Thread.Sleep(500);
            Write(".");
            Beep(5000, 100);
            Thread.Sleep(500);
            Write(".");
            Beep(5000, 100);
            Thread.Sleep(500);
            Write(".");
            Beep(5000, 100);
            Thread.Sleep(500);
            Clear();
            Beep(2500, 750);
            WriteLine("==============================================================");
            Thread.Sleep(100);
            WriteLine("||                                                          ||");
            Thread.Sleep(100);
            WriteLine("||   +----+   +----+   +----+     +----+                    ||");
            Thread.Sleep(100);
            WriteLine("||   |     |  |    |   |     |    |    |                    ||");
            Thread.Sleep(100);
            WriteLine("||   |     |  |    |   |     |    |    |                    ||");
            Thread.Sleep(100);
            WriteLine("||   +----+   |    |   +----+     |----|                    ||");
            Thread.Sleep(100);
            WriteLine("||   |     |  |    |   |    \\     |    |                    ||");
            Thread.Sleep(100);
            WriteLine("||   +----+   +----+   |     \\    |    |                    ||");
            Thread.Sleep(100);
            WriteLine("||                                                          ||");
            Thread.Sleep(100);
            WriteLine("||   +----+   +-----+                                       ||");
            Thread.Sleep(100);
            WriteLine("||   |     |  |                                             ||");
            Thread.Sleep(100);
            WriteLine("||   |     |  |                                             ||");
            Thread.Sleep(100);
            WriteLine("||   |     |  +----+                                        ||");
            Thread.Sleep(100);
            WriteLine("||   |     |  |                                             ||");
            Thread.Sleep(100);
            WriteLine("||   |     |  |                                             ||");
            Thread.Sleep(100);
            WriteLine("||   +----+   +-----+                                       ||");
            Thread.Sleep(100);
            WriteLine("||                                                          ||");
            Thread.Sleep(100);
            WriteLine("||   +----+   |     |   +----+   +----+                     ||");
            Thread.Sleep(100);
            WriteLine("||   |        |     |   |        |    |                     ||");
            Thread.Sleep(100);
            WriteLine("||   +----+   |     |   |        |    |                     ||");
            Thread.Sleep(100);
            WriteLine("||        |   |     |   |        |    |                     ||");
            Thread.Sleep(100);
            WriteLine("||        |   |     |   |        |    |                     ||");
            Thread.Sleep(100);
            WriteLine("||   +----+   \\_____/   +----+   +----+                     ||");
            Thread.Sleep(100);
            WriteLine("||                                                          ||");
            Thread.Sleep(100);
            WriteLine("==============================================================");
            Thread.Sleep(100);
            WriteLine("\n");
            WriteLine("Tecle qualquer tecla para continuar");
            ReadKey();

            WriteLine();
        }
    }
