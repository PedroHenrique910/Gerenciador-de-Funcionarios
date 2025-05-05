// A classe Desenvolvedor herda da classe Funcionario
public class Desenvolvedor : Funcionario
{
    public int HorasExtras { get; set; }

    public decimal ValorPorHoraExtra { get; set; }

    // Método sobrescrito que calcula o salário considerando horas extras e desconto de 10% de imposto
    public override void CalcularSalario()
    {
        decimal salarioBruto = Salario + (HorasExtras * ValorPorHoraExtra);

        decimal imposto = salarioBruto * 0.10m;

        // Salário final (líquido) após o desconto do imposto
        Salario = salarioBruto - imposto;
    }

    // Método sobrescrito que retorna o valor de imposto sobre o salário atual
    public override decimal CalcularImpostos()
    {
        return Salario * 0.10m;
    }

    // Método sobrescrito de Funcionario que simula a entrega do pagamento, exibindo os dados no console
    public override void EntregarPagamento()
    {
        Console.WriteLine($"--- Pagamento do desenvolvedor {Nome} ---");
        Console.WriteLine($"Valor líquido: {Salario:C}");
        Console.WriteLine($"Forma de pagamento: {FormaDePagamento}");
        Console.WriteLine($"Método de entrega: {MetodoDeEntregaDoPagamento}");
        Console.WriteLine("--------------------------\n");
    }
}
