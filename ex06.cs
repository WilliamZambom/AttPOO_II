/*
Sistema simples de uma loja de roupas online
*/

using System;

class Produto
{
    public string nome;
    public double preco;
    public int estoque;

    public Produto(string nome, double preco, int estoque)
    {
        this.nome = nome;
        this.preco = preco;
        this.estoque = estoque;
    }

    public void mostrarDados()
    {
        Console.WriteLine("Produto: " + nome);
        Console.WriteLine("Preco: " + preco);
        Console.WriteLine("Estoque: " + estoque);
    }

    public void atualizarEstoque(int quantidade)
    {
        estoque = quantidade;
        Console.WriteLine("Estoque atualizado para: " + estoque);
    }

    public double calcularValorTotal()
    {
        return preco * estoque;
    }
}

class Program
{
    static void Main()
    {
        Produto p1 = new Produto("Camiseta", 59.90, 10);
        Produto p2 = new Produto("Calça Jeans", 120.00, 5);
        Produto p3 = new Produto("Jaqueta", 199.90, 3);

        Console.WriteLine("Produtos da loja:\n");

        p1.mostrarDados();
        Console.WriteLine("Valor total em estoque: " + p1.calcularValorTotal());
        Console.WriteLine();

        p2.mostrarDados();
        Console.WriteLine("Valor total em estoque: " + p2.calcularValorTotal());
        Console.WriteLine();

        p3.mostrarDados();
        Console.WriteLine("Valor total em estoque: " + p3.calcularValorTotal());
    }
}
