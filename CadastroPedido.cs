public class CadastroPedido
{
    public Pedido PedidoCadastro(GenericRepository<Cliente> clientes,  GenericRepository<Funcionario> atendentes, GenericRepository<Suco> sucos)
    {
        
        Pedido pedido = new Pedido();
        
        Console.WriteLine("--------------- Cadastro de Pedido ---------------");
        Console.WriteLine("\n");
        
        bool genericBool = false; //Serve tanto pra ver se tem registro, e também pra whiles no geral
        string resposta;
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
                    pedido.Adicional = resposta;
                    resposta = "";
                    Console.WriteLine("Insira o preço do adicional");
                    precoExtra = Convert.ToDecimal(Console.ReadLine());
                    genericBool = true;
                    break;
                case "2":
                    pedido.Adicional = "Sem adicional";
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
