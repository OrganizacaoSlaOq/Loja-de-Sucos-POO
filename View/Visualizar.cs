public class Visualizar
{
    private string resposta;  
    
    public void VisualizarCliente(GenericController<Cliente> clientes)
    {
        Cliente clienteEscolhido;
        
        Console.WriteLine("Escolha um cliente para visualizar:");
        Console.WriteLine("(Digite o Id do Cliente Escolhido):");
        
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
                Console.WriteLine($"Confirma em Visualizar {clienteEscolhido.Nome}?");
                Console.WriteLine("1) Sim");
                Console.WriteLine("2) Não");
                resposta = Console.ReadLine().ToUpper();
                if (resposta == "1" || resposta == "SIM")
                {
                    Console.WriteLine(clienteEscolhido.ToString());
                    resposta = "";
                    Console.WriteLine("\nTecle qualquer tecla pra voltar.");
                    Console.ReadKey();
                    Console.Clear();
                    return;
                    
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
    public void VisualizarFuncionario(GenericController<Funcionario> funcionarios)
    {
        Funcionario funcionarioEscolhido;
        
        Console.WriteLine("Escolha um funcionario para visualizar:");
        Console.WriteLine("(Digite o Id do Cliente Escolhido):");
        
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
                Console.WriteLine($"Confirma em Visualizar {funcionarioEscolhido.Nome}?");
                Console.WriteLine("1) Sim");
                Console.WriteLine("2) Não");
                resposta = Console.ReadLine().ToUpper();
                if (resposta == "1" || resposta == "SIM")
                {
                    Console.WriteLine(funcionarioEscolhido.ToString());
                    resposta = "";
                    Console.WriteLine("\nTecle qualquer tecla pra voltar.");
                    Console.ReadKey();
                    Console.Clear();
                    return;
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
    public void VisualizarSuco(GenericController<Suco> sucos)
    {
        Suco sucoEscolhido;
        
        Console.WriteLine("Escolha um Suco para visualizar:");
        Console.WriteLine("(Digite o Id do Suco Escolhido):");
        
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
                Console.WriteLine($"Confirma em Visualizar {sucoEscolhido.NomeSuco}?");
                Console.WriteLine("1) Sim");
                Console.WriteLine("2) Não");
                resposta = Console.ReadLine().ToUpper();
                if (resposta == "1" || resposta == "SIM")
                {
                    Console.WriteLine(sucoEscolhido.ToString());
                    resposta = "";
                    Console.WriteLine("\nTecle qualquer tecla pra voltar.");
                    Console.ReadKey();
                    Console.Clear();
                    return;
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
    public void VisualizarPedido(GenericController<Pedido> pedidos)
    {
        Pedido pedidoEscolhido;
        
        Console.WriteLine("Escolha um Pedido para visualizar:");
        Console.WriteLine("(Digite o Id do Cliente Escolhido):");
        
        foreach (Pedido pedido in pedidos.MimDePapai())
        {
            Console.WriteLine($"{pedido.Id}. pedido de {pedido.Cliente.Nome}");
        }
        resposta = Console.ReadLine();

        foreach (Pedido Pedido in pedidos.MimDePapai())
        {
            if (Pedido.Id == Convert.ToInt32(resposta))
            {
                pedidoEscolhido = Pedido;
                resposta = "";
                Console.WriteLine($"Confirma em visualizar o pedido de {pedidoEscolhido.Cliente.Nome}?");
                Console.WriteLine("1) Sim");
                Console.WriteLine("2) Não");
                resposta = Console.ReadLine().ToUpper();
                if (resposta == "1" || resposta == "SIM")
                {
                    Console.WriteLine(pedidoEscolhido.ToString());
                    resposta = "";
                    Console.WriteLine("\nTecle qualquer tecla pra voltar.");
                    Console.ReadKey();
                    Console.Clear();
                    return;
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
    public void VisualizarEndereco(GenericController<Endereco> enderecos)
    {
        Endereco enderecoEscolhido;
        
        Console.WriteLine("Escolha um endereco para visualizar:");
        Console.WriteLine("(Digite o Id do Cliente Escolhido):");
        
        foreach (Endereco endereco in enderecos.MimDePapai())
        {
            Console.WriteLine($"{endereco.Id}. {endereco.Logradouro}");
        }
        resposta = Console.ReadLine();

        foreach (Endereco endereco in enderecos.MimDePapai())
        {
            if (endereco.Id == Convert.ToInt32(resposta))
            {
                enderecoEscolhido = endereco;
                resposta = "";
                Console.WriteLine($"Confirma em Visualizar {enderecoEscolhido.Logradouro}?");
                Console.WriteLine("1) Sim");
                Console.WriteLine("2) Não");
                resposta = Console.ReadLine().ToUpper();
                if (resposta == "1" || resposta == "SIM")
                {
                    Console.WriteLine(enderecoEscolhido.ToString());
                    resposta = "";
                    Console.WriteLine("\nTecle qualquer tecla pra voltar.");
                    Console.ReadKey();
                    Console.Clear();
                    return;
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
    public void VisualizarTelefone(GenericController<Telefone> telefones)
    {
        Telefone telefoneEscolhido;
        
        Console.WriteLine("Escolha um endereco para visualizar:");
        Console.WriteLine("(Digite o Id do Cliente Escolhido):");
        
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
                Console.WriteLine($"Confirma em Visualizar ({telefoneEscolhido.Ddd}) {telefoneEscolhido.Numero}?");
                Console.WriteLine("1) Sim");
                Console.WriteLine("2) Não");
                resposta = Console.ReadLine().ToUpper();
                if (resposta == "1" || resposta == "SIM")
                {
                    Console.WriteLine(telefoneEscolhido.ToString());
                    resposta = "";
                    Console.WriteLine("\nTecle qualquer tecla pra voltar.");
                    Console.ReadKey();
                    Console.Clear();
                    return;
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
}
