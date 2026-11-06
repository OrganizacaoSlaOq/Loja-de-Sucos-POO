public class Deletar
{
    private string resposta;
    
    public void DeletarCliente(GenericController<Cliente> clientes)
    {
        Cliente clienteEscolhido;
        
        Console.WriteLine("Escolha um cliente para eliminar:");
        Console.WriteLine("Digite o Id do Cliente Escolhido:");
        
        foreach (Cliente cliente in clientes.MimDePapai())
        {
            Console.WriteLine($"{cliente.Id}. {cliente.Nome}");
        }
        resposta = Console.ReadLine();

        foreach (Cliente cliente in clientes.MimDePapai())
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
                    clientes.Deletar(cliente);
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
    public void DeletarFuncionario(GenericController<Funcionario> funcionarios)
    {
        Funcionario funcionarioEscolhido;
        
        Console.WriteLine("Escolha um Funcionario para eliminar:");
        Console.WriteLine("Digite o Id do Funcionario Escolhido:");
        
        foreach (Funcionario funcionario in funcionarios.MimDePapai())
        {
            Console.WriteLine($"{funcionario.Id}. {funcionario.Nome}");
        }
        resposta = Console.ReadLine();

        foreach (Funcionario funcionario in funcionarios.MimDePapai())
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
                    funcionarios.Deletar(funcionario);
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
    public void DeletarSuco(GenericController<Suco> sucos)
    {
        Suco sucoEscolhido;
        
        Console.WriteLine("Escolha um Suco para eliminar:");
        Console.WriteLine("Digite o Id do Suco Escolhido:");
        
        foreach (Suco suco in sucos.MimDePapai())
        {
            Console.WriteLine($"{suco.Id}. {suco.NomeSuco}");
        }
        resposta = Console.ReadLine();

        foreach (Suco suco in sucos.MimDePapai())
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
                    sucos.Deletar(suco);
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
    public void DeletarPedido(GenericController<Pedido> pedidos)
    {
        Pedido pedidoEscolhido;
        
        Console.WriteLine("Escolha um pedido para eliminar:");
        Console.WriteLine("Digite o Id do pedido Escolhido:");
        
        foreach (Pedido pedido in pedidos.MimDePapai())
        {
            Console.WriteLine($"{pedido.Id}. Cliente que fez o pedido: {pedido.Cliente.Nome}");
        }
        resposta = Console.ReadLine();

        foreach (Pedido pedido in pedidos.MimDePapai())
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
                    pedidos.Deletar(pedido);
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
    public void DeletarEndereco(GenericController<Endereco> enderecos)
    {
        Endereco enderecoEscolhido;
        
        Console.WriteLine("Escolha um endereco para eliminar:");
        Console.WriteLine("Digite o Id do endereco Escolhido:");
        
        foreach (Endereco endereco in enderecos.MimDePapai())
        {
            Console.WriteLine($"{endereco.Id}. Logradouro: {endereco.Logradouro}");
        }
        resposta = Console.ReadLine();

        foreach (Endereco endereco in enderecos.MimDePapai())
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
                    enderecos.Deletar(endereco);
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
    public void DeletarTelefone(GenericController<Telefone> telefones)
    {
        Telefone telefoneEscolhido;
        
        Console.WriteLine("Escolha um telefone para eliminar:");
        Console.WriteLine("Digite o Id do telefone Escolhido:");
        
        foreach (Telefone telefone in telefones.MimDePapai())
        {
            Console.WriteLine($"{telefone.Id}. ({telefone.Ddd}) {telefone.Numero}");
        }
        resposta = Console.ReadLine();

        foreach (Telefone telefone in telefones.MimDePapai())
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
                    telefones.Deletar(telefone);
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
