using System.Text;
public class GenericService<T>
{
    public void Exportar(string caminhoArquivo, List<T> itens, string cabecalho, Func<T, string> conversorDeLinha)
    {
        var sb = new StringBuilder();
        sb.AppendLine(cabecalho);
        foreach (var item in itens)
        {
            sb.AppendLine(conversorDeLinha(item));
        }
        File.WriteAllText(caminhoArquivo, sb.ToString());
    }
    
}
