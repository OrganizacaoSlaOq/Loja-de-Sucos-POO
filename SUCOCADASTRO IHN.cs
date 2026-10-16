using Model;

public class CadastroSuco
{
    public Suco SucoCadastro()
    {
        Suco suco = new Suco();

        Console.WriteLine("\t****** [CADASTRO DE SUCO] ******");
        
        Console.Write("Nome do suco: ");
        suco.NomeSuco = Console.ReadLine();
        
        Console.Write("Descrição do suco: ");
        suco.Descricao = Console.ReadLine();
        
        Console.Write("Preço do suco: ");
        suco.Preco = Convert.ToDecimal(Console.ReadLine());
        
        return suco;
    }
}
