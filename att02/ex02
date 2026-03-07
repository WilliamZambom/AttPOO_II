using System;

interface ITransporteVoador
{
    void Voar(string origem, string destino, int passageiros);
}

class Aviao : ITransporteVoador
{
    public void Voar(string origem, string destino, int passageiros)
    {
        Console.WriteLine("Avião voando");
        Console.WriteLine("O: " + origem + " / D: " + destino + " / QtdP: " + passageiros);
    }
}

class Helicoptero : ITransporteVoador
{
    public void Voar(string origem, string destino, int passageiros)
    {
        Console.WriteLine("Helicóptero voando");
        Console.WriteLine("O: " + origem + " / D: " + destino + " / QtdP: " + passageiros);
    }
}

class Grifo : ITransporteVoador
{
    public void Voar(string origem, string destino, int passageiros)
    {
        Console.WriteLine("Grifo voando");
        Console.WriteLine("O: " + origem + " / D: " + destino + " / QtdP: " + passageiros);
    }
}

class Aeroporto
{
    public ITransporteVoador? Veiculo { get; set; }

    public bool Aceitar(ITransporteVoador voador, string origem, string destino, int passageiros)
    {
        if (Veiculo != null)
        {
            Console.WriteLine("Aeroporto ocupado");
            return false;
        }

        Veiculo = voador;
        Veiculo.Voar(origem, destino, passageiros);
        return true;
    }

    public void Limpar()
    {
        Veiculo = null;
    }
}

class Program
{
    static void Main()
    {
        Aeroporto aeroporto = new Aeroporto();
        Grifo grifo = new Grifo();
        Aviao aviao = new Aviao();
        Helicoptero helicoptero = new Helicoptero();

        aeroporto.Aceitar(grifo, "Vix", "VV", 1);
        aeroporto.Aceitar(aviao, "Vix", "VV", 10);
        aeroporto.Limpar();
        aeroporto.Aceitar(helicoptero, "Vix", "VV", 20);
    }
}
