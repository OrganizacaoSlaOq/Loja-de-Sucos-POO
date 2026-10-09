public class GenericService<T>
{
    public void Exportar(string caminhoArquivo, List<T> itens, string cabecalho, Func<T, string> conversorDeLinha)
    {
        var sb = new StringBuilder();
        sb.Append(cabecalho);
        foreach (var item in itens)
        {
            sb.Append(conversorDeLinha(item));
        }
        File.WriteAllText(caminhoArquivo, sb.ToString());
    }
    
}
