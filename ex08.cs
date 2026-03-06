/*
Sistema simples de Dicionario
*/

using System;
using System.Collections.Generic;

class Significado
{
    public string texto;

    public Significado(string t)
    {
        texto = t;
    }
}

class Palavra
{
    public string nome;
    private List<Significado> significados = new List<Significado>();

    public Palavra(string n)
    {
        nome = n;
    }

    public void adicionarSignificado(Significado s)
    {
        significados.Add(s);
    }

    public List<Significado> recuperarSignificado()
    {
        return significados;
    }

    public void removerSignificado(string texto)
    {
        significados.RemoveAll(s => s.texto == texto);
    }

    public bool pesquisarSignificado(string texto)
    {
        foreach (Significado s in significados)
        {
            if (s.texto == texto)
            {
                return true;
            }
        }

        return false;
    }
}

class Program
{
    static void Main()
    {
        Palavra p = new Palavra("Java");

        p.adicionarSignificado(new Significado("Linguagem de programacao"));
        p.adicionarSignificado(new Significado("Tipo de cafe"));

        Console.WriteLine("Significados da palavra " + p.nome + ":");

        foreach (Significado s in p.recuperarSignificado())
        {
            Console.WriteLine("- " + s.texto);
        }

        Console.WriteLine("Existe significado 'Tipo de cafe'? "
            + p.pesquisarSignificado("Tipo de cafe"));

        p.removerSignificado("Tipo de cafe");

        Console.WriteLine("Significados apos remocao:");

        foreach (Significado s in p.recuperarSignificado())
        {
            Console.WriteLine("- " + s.texto);
        }
    }
}
