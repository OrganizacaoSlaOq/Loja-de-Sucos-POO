public class Funcionario : Pessoa
{
    public string Cargo { get; set; }
    public decimal Salario { get; set; }
    
    public override string ToString()
    {
        return $"---------- DADOS DO FUNCIONÁRIO ----------\n" +
               $"{base.ToString()}" +
               $"Cargo: {Cargo}" +
               $"Salaário {Salario:C2}";
    }
}
