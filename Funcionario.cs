// Classe abstrata que serve como base para outros tipos de funcionário
public abstract class Funcionario
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string? Cargo { get; set; }
    public decimal Salario { get; set; }
    public string? FormaDePagamento { get; set; }
    public string? MetodoDeEntregaDoPagamento { get; set; }

    // Lista estática para armazenar todos os funcionários cadastrados
    private readonly static List<Funcionario> funcionarios = [];

    // Método estático que adiciona um novo funcionário à lista
    public static void AddFuncionario(Funcionario newFuncionario)
    {
        funcionarios.Add(newFuncionario);
        Console.WriteLine($"Funcionário {newFuncionario.Nome} " +
          $"adicionado com sucesso.");
    }

    // Método estático que exibe todos os funcionários cadastrados
    public static void DisplayFuncionarios()
    {
        foreach (var funcionario in funcionarios)
            Console.WriteLine($"Nome: {funcionario.Nome}, " +
              $"Idade: {funcionario.Idade}, Cargo: {funcionario.Cargo}, " +
              $"Salário: {funcionario.Salario:C}, "
              + $"Forma de pagamento: {funcionario.FormaDePagamento}, "
              + $"Método de pagamento: {funcionario.MetodoDeEntregaDoPagamento}");
    }

    // Método abstrato que força as classes filhas a implementarem o cálculo de salário
    public abstract void CalcularSalario();

    // Método virtual que calcula impostos (por padrão 0%). Pode ser sobrescrito pelas subclasses.
    public virtual decimal CalcularImpostos()
    {
        return Salario * 0m;
    }

    // Método virtual para exibir os dados do pagamento. Pode ser sobrescrito.
    public virtual void EntregarPagamento()
    {
        Console.WriteLine($"--- Pagamento de {Nome} ---");
        Console.WriteLine($"Valor líquido: {Salario:C}");
        Console.WriteLine($"Forma de pagamento: {FormaDePagamento}");
        Console.WriteLine($"Método de entrega: {MetodoDeEntregaDoPagamento}");
        Console.WriteLine("--------------------------\n");
    }
}
