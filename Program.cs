Menu menu = new Menu();

var ctrlCliente = new GenericController<Cliente>(new GenericRepository<Cliente>(), new GenericView<Cliente>(), new GenericService<Cliente>());
var ctrlPedido = new GenericController<Pedido>(new GenericRepository<Pedido>(), new GenericView<Pedido>(), new GenericService<Pedido>());
var ctrlEndereco = new GenericController<Endereco>(new GenericRepository<Endereco>(), new GenericView<Endereco>(), new GenericService<Endereco>());
var ctrlFuncionario= new GenericController<Funcionario>(new GenericRepository<Funcionario>(), new GenericView<Funcionario>(), new GenericService<Funcionario>());
var ctrlSuco = new GenericController<Suco>(new GenericRepository<Suco>(), new GenericView<Suco>(), new GenericService<Suco>());
var ctrlTelefone = new GenericController<Telefone>(new GenericRepository<Telefone>(), new GenericView<Telefone>(), new GenericService<Telefone>());

menu.TituloAbertura();
Console.WriteLine("============================\n");

string opc;

do
{
    Console.WriteLine("Bem vindo ao menu do Bora de Suco! Escolha uma das opções para continuar:\n");
    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Deletar");
    Console.WriteLine("3 - Salvar");
    Console.WriteLine("4 - Visualizar");
            
    Console.WriteLine("0 - Sair do programa");

    Console.Write("\n>>> ");

    opc = Console.ReadLine();
    Console.Clear();

    switch (opc)
    {
        case "1":
            Console.Clear();
            menu.MenuCadastrar(ctrlCliente,ctrlFuncionario,ctrlSuco,ctrlPedido,ctrlEndereco,ctrlTelefone);
            Console.Clear();
            break;

        case "2":
            Console.Clear();
            menu.MenuDeletar(ctrlCliente,ctrlFuncionario,ctrlSuco,ctrlPedido,ctrlEndereco,ctrlTelefone);
            Console.Clear();
            break;

        case "3":
            Console.Clear();
            menu.MenuSalvar(ctrlCliente,ctrlFuncionario,ctrlSuco,ctrlPedido,ctrlEndereco,ctrlTelefone);
            Console.Clear();
            break;
        case "4":
            Console.Clear();
            menu.MenuVisualizar(ctrlCliente,ctrlFuncionario,ctrlSuco,ctrlPedido,ctrlEndereco,ctrlTelefone);
            Console.Clear();
            break;
        case "0":
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nVolte Sempre!!!");
            Thread.Sleep(1000);
            break;

        default:
            Console.Write("Opção inválida, tente novamente...");
            Console.ReadKey();
            Console.Clear();
            break;
    }
} while (opc != "0");
