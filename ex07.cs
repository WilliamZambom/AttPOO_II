/*
Sistema de Cofrinho
*/

using System;
using System.Collections.Generic;

class Moeda
{
    private double valor;
    private string nome;

    public Moeda(double v, string n)
    {
        valor = v;
        nome = n;
    }

    public double getValor()
    {
        return valor;
    }

    public string getNome()
    {
        return nome;
    }
}

class Cofrinho
{
    private List<Moeda> moedas = new List<Moeda>();

    public void adicionar(Moeda m)
    {
        moedas.Add(m);
    }

    public double calcularTotal()
    {
        double total = 0;

        foreach (Moeda m in moedas)
        {
            total += m.getValor();
        }

        return total;
    }

    public int contarMoedas()
    {
        return moedas.Count;
    }

    public int contarMoedasValor(double valor)
    {
        int cont = 0;

        foreach (Moeda m in moedas)
        {
            if (m.getValor() == valor)
            {
                cont++;
            }
        }

        return cont;
    }

    public Moeda maiorMoeda()
    {
        Moeda maior = moedas[0];

        foreach (Moeda m in moedas)
        {
            if (m.getValor() > maior.getValor())
            {
                maior = m;
            }
        }

        return maior;
    }
}

class Program
{
    static void Main()
    {
        Cofrinho c = new Cofrinho();

        c.adicionar(new Moeda(0.10, "10 centavos"));
        c.adicionar(new Moeda(0.50, "50 centavos"));
        c.adicionar(new Moeda(1.00, "1 real"));
        c.adicionar(new Moeda(0.25, "25 centavos"));

        Console.WriteLine("Total no cofrinho: " + c.calcularTotal());
        Console.WriteLine("Quantidade de moedas: " + c.contarMoedas());
        Console.WriteLine("Moedas de 1 real: " + c.contarMoedasValor(1.00));

        Moeda maior = c.maiorMoeda();
        Console.WriteLine("Maior moeda: " + maior.getNome());
    }
}
