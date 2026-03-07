using System;

interface Capitalizacao
{
    void calculaPremio();
}

class ContaDeBanco
{
    protected double saldo;

    public ContaDeBanco(double saldo)
    {
        this.saldo = saldo;
    }

    public void deposito(double valor)
    {
        saldo += valor;
    }

    public void retirada(double valor)
    {
        saldo -= valor;
    }

    public virtual void mostraSaldo()
    {
        Console.WriteLine("Saldo: " + saldo);
    }
}

class ContaPoupanca : ContaDeBanco, Capitalizacao
{
    public int diaAniversario;
    public double correcao;

    public ContaPoupanca(double saldo, int diaAniversario, double correcao)
        : base(saldo)
    {
        this.diaAniversario = diaAniversario;
        this.correcao = correcao;
    }

    public void corrigeSaldo()
    {
        saldo += saldo * correcao;
    }

    public void calculaPremio()
    {
        corrigeSaldo();
    }

    public override void mostraSaldo()
    {
        Console.WriteLine("Saldo Poupanca: " + saldo);
    }
}

class ContaEspecial : ContaDeBanco, Capitalizacao
{
    public double limite;

    public ContaEspecial(double saldo, double limite) : base(saldo)
    {
        this.limite = limite;
    }

    public void calculaPremio()
    {
        saldo += limite * 0.05;
    }

    public override void mostraSaldo()
    {
        Console.WriteLine("Saldo Especial: " + saldo + " / Limite: " + limite);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Saldo inicial poupanca: ");
        double sp = double.Parse(Console.ReadLine());

        Console.Write("Dia aniversario: ");
        int dia = int.Parse(Console.ReadLine());

        Console.Write("Correcao: ");
        double cor = double.Parse(Console.ReadLine());

        ContaPoupanca cp = new ContaPoupanca(sp, dia, cor);
        cp.calculaPremio();
        cp.mostraSaldo();

        Console.Write("Saldo inicial especial: ");
        double se = double.Parse(Console.ReadLine());

        Console.Write("Limite: ");
        double lim = double.Parse(Console.ReadLine());

        ContaEspecial ce = new ContaEspecial(se, lim);
        ce.calculaPremio();
        ce.mostraSaldo();
    }
}
