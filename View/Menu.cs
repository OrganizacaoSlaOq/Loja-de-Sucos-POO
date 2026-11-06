using System.Console;

public class Menu
{
    
    public void MenuCadastrar(GenericController<Cliente> clienteController,
        GenericController<Funcionario> funcionarioController, GenericController<Suco> sucoController,
        GenericController<Pedido> pedidoController, GenericController<Endereco> enderecoController,
        GenericController<Telefone> telefoneController)
    {
        Cadastros cadastros = new Cadastros();

        Console.WriteLine("Escolha algo para cadastrar\n");
        Console.WriteLine("1 - Cliente");
        Console.WriteLine("2 - Funcionário");
        Console.WriteLine("3 - Suco");
        Console.WriteLine("4 - Pedido");
        Console.WriteLine("0 - Voltar ao menu principal");

        Console.Write("\n>>> ");
        string opc;
        opc = Console.ReadLine();
        do
        {

            switch (opc)
            {
                case "1":
                    clienteController.Cadastrar(cadastros.CadastroCliente());
                    break;
                
                case "2":
                    funcionarioController.Cadastrar(cadastros.CadastroFuncionario());
                    break;

                case "3":
                    sucoController.Cadastrar(cadastros.CadastroSuco());
                    break;

                case "4":
                    pedidoController.Cadastrar(cadastros.CadastroPedido(clienteController, funcionarioController,sucoController));
                    break;

                case "0":
                    Console.WriteLine("Tecle qualquer tecla pra voltar.");
                    Console.ReadKey();
                    Console.Clear();
                    break;

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

        Console.WriteLine("Escolha algo para Deletar\n");
        Console.WriteLine("1 - Cliente");
        Console.WriteLine("2 - Funcionário");
        Console.WriteLine("3 - Suco");
        Console.WriteLine("4 - Pedido");
        Console.WriteLine("0 - Voltar ao menu principal");

        Console.Write("\n>>> ");
        string opc;
        opc = Console.ReadLine();
        do
        {

            switch (opc)
            {
                case "1":
                    deletar.DeletarCliente(clienteController);
                    break;
                
                case "2":
                    deletar.DeletarFuncionario(funcionarioController);
                    break;

                case "3":
                    deletar.DeletarSuco(sucoController);
                    break;

                case "4":
                    deletar.DeletarPedido(pedidoController);
                    break;

                case "0":
                    Console.WriteLine("Tecle qualquer tecla pra voltar.");
                    Console.ReadKey();
                    Console.Clear();
                    break;

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

        Console.WriteLine("Escolha algo para Salvar\n");
        Console.WriteLine("1 - Clientes");
        Console.WriteLine("2 - Funcionários");
        Console.WriteLine("3 - Sucos");
        Console.WriteLine("4 - Pedidos");
        Console.WriteLine("5 - Endereco");
        Console.WriteLine("6 - Funcionario");
        Console.WriteLine("0 - Voltar ao menu principal");

        Console.Write("\n>>> ");
        string opc;
        opc = Console.ReadLine();
        do
        {

            switch (opc)
            {
                case "1":
                    clienteController.Processar(
                        "Lista de Clientes",
                        "clientes.csv",
                        "Id;Nome;Cpf;Email;DataNascimento;NumeroTelefone;EnderecoLogradouro",
                        c=>$"{c.Id};{c.Cpf};{c.Email};{c.DataNascimento.ToShortDateString()};{c.Telefone.ToString()};{c.Endereco.Logradouro}"
                        );
                    break;
                
                case "2":
                    funcionarioController.Processar(
                        "Lista de Funcionario",
                        "funcionarios.csv",
                        "Id;Nome;Cpf;Email;DataNascimento;NumeroTelefone;EnderecoLogradouro;Carco;Salario",
                        f=>$"{f.Id};{f.Cpf};{f.Email};{f.DataNascimento.ToShortDateString()};{f.Telefone.ToString()};{f.Endereco.Logradouro};{f.Cargo};{f.Salario:C2}"
                    );
                    break;

                case "3":
                    sucoController.Processar(
                        "Lista de Suco",
                        "sucos.csv",
                        "Id;NomeSuco;Descricao;Preco",
                        s => $"{s.Id};{s.NomeSuco};{s.Descricao};{s.Preco:C2}"
                    );
                    break;

                case "4":
                    pedidoController.Processar(
                        "Lista de Pedidos",
                        "pedidos.csv",
                        "Id;IdCliente;NomeCliente;IdAtendente;NomeAtendente;IdSuco;NomeSuco;Extras;Preco",
                        p => $"{p.Id};{p.Cliente.Id};{p.Cliente.Nome};{p.Atendente.Id};{p.Atendente.Nome};{p.Suco.Id};{p.Suco.NomeSuco};{p.Extras};{p.Preco:C2}"
                    );
                    break;
                case "5":
                    enderecoController.Processar(
                        "Lista de Enderecos",
                        "enderecos.csv",
                        "Id;Logradouro;Bairro;NomeAtendente;IdSuco;NomeSuco;Extras;Preco",
                        p => $"{p.Id};{p.Cliente.Id};{p.Cliente.Nome};{p.Atendente.Id};{p.Atendente.Nome};{p.Suco.Id};{p.Suco.NomeSuco};{p.Extras};{p.Preco:C2}"
                    );
                    break;

                case "0":
                    Console.WriteLine("Tecle qualquer tecla pra voltar.");
                    Console.ReadKey();
                    Console.Clear();
                    break;

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

}
