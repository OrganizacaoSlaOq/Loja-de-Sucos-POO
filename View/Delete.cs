using Nga.Model;

namespace Nga.Menu;

public class Delete
{
    private string resposta;
    
    public void DeletarCliente(GenericRepository<Cliente> repositorioClientes)
    {
        Cliente clienteEscolhido;
        
        Console.WriteLine("Escolha um cliente para eliminar:");
        Console.WriteLine("Digite o Id do Cliente Escolhido:");
        
        foreach (Cliente cliente in repositorioClientes.GetAll())
        {
            Console.WriteLine($"{cliente.Id}. {cliente.Nome}");
        }
        resposta = Console.ReadLine();

        foreach (Cliente cliente in repositorioClientes.GetAll())
        {
            if (cliente.Id == Convert.ToInt32(resposta))
            {
                clienteEscolhido = cliente;
                resposta = "";
                Console.WriteLine($"Confirma em deletar {cliente.Nome}?");
                Console.WriteLine("1) Sim");
                Console.WriteLine("2) Não");
                resposta = Console.ReadLine().ToUpper();
                if (resposta == "1" || resposta == "SIM")
                {
                    repositorioClientes.Delete(cliente);
                    resposta = "";
                }
                else if (resposta == "2" || resposta == "NÃO")
                {
                    return;
                }
                else
                {
                    Console.WriteLine($"Opção Inválida");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Cliente Não Encontrado");
                return;
            }
        }
    }
    public void DeletarFuncionario(GenericRepository<Funcionario> repositorioFuncionarios)
    {
        Funcionario funcionarioEscolhido;
        
        Console.WriteLine("Escolha um Funcionario para eliminar:");
        Console.WriteLine("Digite o Id do Funcionario Escolhido:");
        
        foreach (Funcionario funcionario in repositorioFuncionarios.GetAll())
        {
            Console.WriteLine($"{funcionario.Id}. {funcionario.Nome}");
        }
        resposta = Console.ReadLine();

        foreach (Funcionario funcionario in repositorioFuncionarios.GetAll())
        {
            if (funcionario.Id == Convert.ToInt32(resposta))
            {
                funcionarioEscolhido = funcionario;
                resposta = "";
                Console.WriteLine($"Confirma em deletar {funcionario.Nome}?");
                Console.WriteLine("1) Sim");
                Console.WriteLine("2) Não");
                resposta = Console.ReadLine().ToUpper();
                if (resposta == "1" || resposta == "SIM")
                {
                    repositorioFuncionarios.Delete(funcionario);
                    resposta = "";
                }
                else if (resposta == "2" || resposta == "NÃO")
                {
                    return;
                }
                else
                {
                    Console.WriteLine($"Opção Inválida");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Funcionário Não Encontrado");
                return;
            }
        }
    }
    public void DeletarFuncionario(GenericRepository<Suco> repositorioSuco)
    {
        Suco sucoEscolhido;
        
        Console.WriteLine("Escolha um Suco para eliminar:");
        Console.WriteLine("Digite o Id do Suco Escolhido:");
        
        foreach (Suco suco in repositorioSuco.GetAll())
        {
            Console.WriteLine($"{suco.Id}. {suco.NomeSuco}");
        }
        resposta = Console.ReadLine();

        foreach (Suco suco in repositorioSuco.GetAll())
        {
            if (suco.Id == Convert.ToInt32(resposta))
            {
                sucoEscolhido = suco;
                resposta = "";
                Console.WriteLine($"Confirma em deletar {suco.NomeSuco}?");
                Console.WriteLine("1) Sim");
                Console.WriteLine("2) Não");
                resposta = Console.ReadLine().ToUpper();
                if (resposta == "1" || resposta == "SIM")
                {
                    repositorioSuco.Delete(suco);
                    resposta = "";
                }
                else if (resposta == "2" || resposta == "NÃO")
                {
                    return;
                }
                else
                {
                    Console.WriteLine($"Opção Inválida");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Suco Não Encontrado");
                return;
            }
        }
    }
    public void DeletarFuncionario(GenericRepository<Pedido> repositoriopedido)
    {
        Pedido pedidoEscolhido;
        
        Console.WriteLine("Escolha um pedido para eliminar:");
        Console.WriteLine("Digite o Id do pedido Escolhido:");
        
        foreach (Pedido pedido in repositoriopedido.GetAll())
        {
            Console.WriteLine($"{pedido.Id}. Cliente que fez o pedido: {pedido.Cliente.Nome}");
        }
        resposta = Console.ReadLine();

        foreach (Pedido pedido in repositoriopedido.GetAll())
        {
            if (pedido.Id == Convert.ToInt32(resposta))
            {
                pedidoEscolhido = pedido;
                resposta = "";
                Console.WriteLine($"Confirma em deletar o pedido de {pedido.Cliente.Nome}?");
                Console.WriteLine("1) Sim");
                Console.WriteLine("2) Não");
                resposta = Console.ReadLine().ToUpper();
                if (resposta == "1" || resposta == "SIM")
                {
                    repositoriopedido.Delete(pedido);
                    resposta = "";
                }
                else if (resposta == "2" || resposta == "NÃO")
                {
                    return;
                }
                else
                {
                    Console.WriteLine($"Opção Inválida");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Pedido Não Encontrado");
                return;
            }
        }
    }
    public void DeletarFuncionario(GenericRepository<Endereco> repositorioEndereco)
    {
        Endereco enderecoEscolhido;
        
        Console.WriteLine("Escolha um endereco para eliminar:");
        Console.WriteLine("Digite o Id do endereco Escolhido:");
        
        foreach (Endereco endereco in repositorioEndereco.GetAll())
        {
            Console.WriteLine($"{endereco.Id}. Logradouro: {endereco.Logradouro}");
        }
        resposta = Console.ReadLine();

        foreach (Endereco endereco in repositorioEndereco.GetAll())
        {
            if (endereco.Id == Convert.ToInt32(resposta))
            {
                enderecoEscolhido = endereco;
                resposta = "";
                Console.WriteLine($"Confirma em deletar o endereco de {endereco.Logradouro}?");
                Console.WriteLine("1) Sim");
                Console.WriteLine("2) Não");
                resposta = Console.ReadLine().ToUpper();
                if (resposta == "1" || resposta == "SIM")
                {
                    repositorioEndereco.Delete(endereco);
                    resposta = "";
                }
                else if (resposta == "2" || resposta == "NÃO")
                {
                    return;
                }
                else
                {
                    Console.WriteLine($"Opção Inválida");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Endereco Não Encontrado");
                return;
            }
        }
    }
    public void DeletarFuncionario(GenericRepository<Telefone> repositorioTelefone)
    {
        Telefone telefoneEscolhido;
        
        Console.WriteLine("Escolha um telefone para eliminar:");
        Console.WriteLine("Digite o Id do telefone Escolhido:");
        
        foreach (Telefone telefone in repositorioTelefone.GetAll())
        {
            Console.WriteLine($"{telefone.Id}. ({telefone.Ddd}) {telefone.Numero}");
        }
        resposta = Console.ReadLine();

        foreach (Telefone telefone in repositorioTelefone.GetAll())
        {
            if (telefone.Id == Convert.ToInt32(resposta))
            {
                telefoneEscolhido = telefone;
                resposta = "";
                Console.WriteLine($"Confirma em deletar o telefone ({telefone.Ddd}) {telefone.Numero}?");
                Console.WriteLine("1) Sim");
                Console.WriteLine("2) Não");
                resposta = Console.ReadLine().ToUpper();
                if (resposta == "1" || resposta == "SIM"|| resposta == "S")
                {
                    repositorioTelefone.Delete(telefone);
                    resposta = "";
                }
                else if (resposta == "2" || resposta == "NÃO" || resposta == "NAO" || resposta == "N")
                {
                    return;
                }
                else
                {
                    Console.WriteLine($"Opção Inválida");
                    return;
                }
            }
            else
            {
                Console.WriteLine("telefone Não Encontrado");
                return;
            }
        }
    }
}
