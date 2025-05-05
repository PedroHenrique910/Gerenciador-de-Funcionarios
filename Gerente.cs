// A classe Gerente herda da classe base Funcionario
public class Gerente : Funcionario
{
    public decimal Bonus { get; set; }

    // Método sobrescrito para calcular o salário do gerente
    public override void CalcularSalario()
    {
        decimal salarioBruto = Salario + Bonus;

        decimal imposto = salarioBruto * 0.275m;

        // Salário líquido após desconto do imposto
        Salario = salarioBruto - imposto;
    }

    // Método sobrescrito para calcular o imposto com base no salário atual
    public override decimal CalcularImpostos()
    {
        return Salario * 0.275m;
    }

    // Método sobrescrito que exibe os detalhes do pagamento no console
    public override void EntregarPagamento()
    {
        Console.WriteLine($"--- Pagamento do gerente: {Nome} ---");
        Console.WriteLine($"Valor líquido: {Salario:C}"); // :C = formato de moeda
        Console.WriteLine($"Forma de pagamento: {FormaDePagamento}");
        Console.WriteLine($"Método de entrega: {MetodoDeEntregaDoPagamento}");
        Console.WriteLine("--------------------------------------\n");
    }
}
