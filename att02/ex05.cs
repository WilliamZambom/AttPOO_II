using System;

class Animal
{
    public string nome;
}

interface FourLegged
{
    void run(string destino);
}

interface OxygenBreather
{
    void breath();
}

class Cat : Animal, FourLegged, OxygenBreather
{
    public void run(string destino)
    {
        Console.WriteLine("Gato correndo para " + destino);
    }

    public void breath()
    {
        Console.WriteLine("Gato respirando");
    }
}

class RoboCat : FourLegged
{
    public void run(string destino)
    {
        Console.WriteLine("RoboCat andando para " + destino);
    }
}

class Program
{
    static void Main()
    {
        Cat c = new Cat();
        RoboCat r = new RoboCat();

        c.run("cozinha");
        c.breath();
        r.run("garagem");
    }
}
