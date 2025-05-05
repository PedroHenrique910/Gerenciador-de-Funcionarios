// A classe Estagiario herda da classe Funcionario
public class Estagiario : Funcionario
{
    // Método sobrescrito que ajusta o salário do estagiário
    public override void CalcularSalario()
    {

        Salario -= CalcularImpostos();
    }

    // Método sobrescrito que simula a entrega do pagamento do estagiário
    public override void EntregarPagamento()
    {
        Console.WriteLine($"--- Pagamento do estagiário {Nome} ---");
        Console.WriteLine($"Valor líquido: {Salario:C}"); // :C formata como moeda
        Console.WriteLine($"Forma de pagamento: {FormaDePagamento}");
        Console.WriteLine($"Método de entrega: {MetodoDeEntregaDoPagamento}");
        Console.WriteLine("--------------------------\n");
    }
}
