// Criação de um gerente
Funcionario gerente = new Gerente
{
    Nome = "João",
    Idade = 40,
    Cargo = "Gerente de Projetos",
    Salario = 10000,
    Bonus = 2000,
    FormaDePagamento = "PIX",
    MetodoDeEntregaDoPagamento = "Automático"
};

// Adiciona o gerente à lista e mostra o pagamento
Funcionario.AddFuncionario(gerente);
Console.WriteLine("\nGerente:\n");
gerente.CalcularSalario();
gerente.EntregarPagamento();

// Criação de um desenvolvedor
Funcionario desenvolvedor = new Desenvolvedor
{
    Nome = "Elias",
    Idade = 57,
    Cargo = "Desenvolvedor de Projetos",
    Salario = 8000,
    HorasExtras = 10,
    ValorPorHoraExtra = 50,
    FormaDePagamento = "Dinheiro",
    MetodoDeEntregaDoPagamento = "Manual"
};

// Adiciona o desenvolvedor à lista e mostra o pagamento
Funcionario.AddFuncionario(desenvolvedor);
Console.WriteLine("\nDesenvolvedor:\n");
desenvolvedor.CalcularSalario();
desenvolvedor.EntregarPagamento();

// Criação de um estagiário
Funcionario estagiario = new Estagiario
{
    Nome = "Victor",
    Idade = 20,
    Cargo = "Estagiário",
    Salario = 1200,
    FormaDePagamento = "PIX",
    MetodoDeEntregaDoPagamento = "Automático"
};

// Adiciona o estagiário à lista e mostra o pagamento
Funcionario.AddFuncionario(estagiario);
Console.WriteLine("\nEstagiário:\n");
estagiario.CalcularSalario();
estagiario.EntregarPagamento();

// Exibe todos os funcionários cadastrados no sistema
Funcionario.DisplayFuncionarios();
