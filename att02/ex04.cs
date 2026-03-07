using System;

class PesoIdealPessoa
{
    public virtual double getPesoIdeal(double altura)
    {
        return 0;
    }
}

class PesoIdealHomem : PesoIdealPessoa
{
    public override double getPesoIdeal(double altura)
    {
        return (72.7 * altura) - 58;
    }
}

class PesoIdealMulher : PesoIdealPessoa
{
    public override double getPesoIdeal(double altura)
    {
        return (62.1 * altura) - 44.7;
    }
}

class PesoIdealPrincipal
{
    static void Main()
    {
        Console.Write("Digite o sexo (M/F): ");
        string sexo = Console.ReadLine();

        Console.Write("Digite a altura: ");
        double altura = double.Parse(Console.ReadLine());

        PesoIdealPessoa p;

        if (sexo == "M" || sexo == "m")
            p = new PesoIdealHomem();
        else
            p = new PesoIdealMulher();

        Console.WriteLine("Peso ideal: " + p.getPesoIdeal(altura));
    }
}
