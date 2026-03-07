using System;

abstract class Militar
{
    public abstract void operacao();
}

class Marinha : Militar
{
    public override void operacao()
    {
        Console.WriteLine("Marinha em operacao no mar");
    }
}

class Exercito : Militar
{
    public override void operacao()
    {
        Console.WriteLine("Exercito em operacao terrestre");
    }
}

class Aeronautica : Militar
{
    public override void operacao()
    {
        Console.WriteLine("Aeronautica em operacao aerea");
    }
}

class Treinamento
{
    public void treinar(Militar[] m)
    {
        foreach (Militar militar in m)
        {
            militar.operacao();
        }
    }
}

class Program
{
    static void Main()
    {
        Militar[] grupo = { new Marinha(), new Exercito(), new Aeronautica() };
        Treinamento t = new Treinamento();
        t.treinar(grupo);
    }
}
