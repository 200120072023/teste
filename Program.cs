
static void Main(string[] args)
{

    //========================================================[E1]============================================================================================
    Empregado e1 = new Empregado("LUCAS ", 7600.0, new DateTime(2023, 1, 1));
    Console.WriteLine($"Nome do empregado: {e1.GetNomeEmpregado()}, Salário do empregado: {e1.GetSalarioEmpregado()}, " +
        $"Data de admissão do empregado: {e1.GetDataAdmissaoEmpregado()}");

    Console.WriteLine($"Soma dos salários:  {Empregado.GetSomaSalarios()}");
     e1.AumentarSalarioEmpregado(13);

    Console.WriteLine($"Novo salário do empregado: {e1.GetNomeEmpregado()} {e1.GetSalarioEmpregado()}");
    Console.WriteLine($"Soma dos salários após aumento: {0} ", Empregado.GetSomaSalarios());





    //===========================================================[E2]=====================================================================================================]

    Empregado e2 = new Empregado("LUCILEIDE", 9000.0, new DateTime(2012, 1, 1));
    Console.WriteLine($"Nome do empregado: {e2.GetNomeEmpregado()}, Salário do empregado: {e2.GetSalarioEmpregado()}," +
        $" Data de admissão do empregado: {e2.GetDataAdmissaoEmpregado()}");

    Console.WriteLine($"Soma dos salários: {Empregado.GetSomaSalarios()}");

    e2.AumentarSalarioEmpregado(9);
    Console.WriteLine($"Novo salário da {e2.GetNomeEmpregado()}: {e2.GetSalarioEmpregado()}");
    Console.WriteLine($"Soma dos salários após aumento: {Empregado.GetSomaSalarios()}");
}
