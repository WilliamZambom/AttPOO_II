using System;

abstract class Professor
{
    public string nome;
    public int matricula;
    public int cargaHoraria;
    protected double beneficio;

    public Professor(string nome, int matricula, int cargaHoraria)
    {
        this.nome = nome;
        this.matricula = matricula;
        this.cargaHoraria = cargaHoraria;
    }

    public abstract void calcularBeneficio();

    public double getBeneficio()
    {
        return beneficio;
    }
}

class ProfDE : Professor
{
    public ProfDE(string nome, int matricula, int cargaHoraria)
        : base(nome, matricula, cargaHoraria) { }

    public override void calcularBeneficio()
    {
        beneficio = 1000;
    }
}

class ProfHorista : Professor
{
    public double valorHora;

    public ProfHorista(string nome, int matricula, int cargaHoraria, double valorHora)
        : base(nome, matricula, cargaHoraria)
    {
        this.valorHora = valorHora;
    }

    public override void calcularBeneficio()
    {
        beneficio = cargaHoraria * valorHora * 0.1;
    }
}

class Program
{
    static void Main()
    {
        ProfDE p1 = new ProfDE("Ana", 1, 40);
        ProfHorista p2 = new ProfHorista("Carlos", 2, 20, 50);

        p1.calcularBeneficio();
        p2.calcularBeneficio();

        Console.WriteLine("ProfDE: " + p1.getBeneficio());
        Console.WriteLine("ProfHorista: " + p2.getBeneficio());
    }
}
