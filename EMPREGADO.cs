class Empregado
{
    private string nomeEmpregado;
    private double salarioEmpregado;
    private DateTime dataAdmissaoEmpregado;

    private static double somaSalarios = 0;

    //===============================================[MÉTODO CONSTRUTOR]=============================================================
    public Empregado(string nomeEmpregado, double salarioEmpregado, DateTime dataAdmissaoEmpregado)
    {
        this.nomeEmpregado = nomeEmpregado;
        this.salarioEmpregado = salarioEmpregado;
        this.dataAdmissaoEmpregado = dataAdmissaoEmpregado;

        somaSalarios += salarioEmpregado;
    }

    //========================================================[GETS]=================================================================
    public string GetNomeEmpregado()
    {
        return nomeEmpregado;
    }
    public double GetSalarioEmpregado()
    {
        return salarioEmpregado;
    }

    public static double GetSomaSalarios()
    {
        return somaSalarios;
    }
    public DateTime GetDataAdmissaoEmpregado()
    {
        return dataAdmissaoEmpregado;
    }

    //=======================================================[SETS]=====================================================================
    public void SetSalario(double salario)
    {
        somaSalarios -= this.salarioEmpregado;
        this.salarioEmpregado = salario;
        somaSalarios += salario;
    }

    public void SetDataAdmissaoEmpregado(DateTime dataAdmissao)
    {
        this.dataAdmissaoEmpregado = dataAdmissao;
    }
    public void SetNomeEmpregado(string nome)
    {
        this.nomeEmpregado = nome;
    }


    //=======================================================[MÉTODO]=====================================================================

    public void AumentarSalarioEmpregado(double percAumento)
    {
        double aumento = salarioEmpregado * (percAumento / 100);
        salarioEmpregado += aumento;
        somaSalarios += aumento;
    }
}