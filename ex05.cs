using System;

class Funcionario
{
    public int matricula;
    public string nome;
    public string cargoAtual;
    public float salarioAtual;

    public void cadastrar()
    {
        Console.WriteLine("Cadastro do funcionário realizado.");
    }

    public void consultar()
    {
        Console.WriteLine("Dados do funcionario:");
        Console.WriteLine("Matricula: " + matricula);
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Cargo: " + cargoAtual);
        Console.WriteLine("Salario: " + salarioAtual);
    }

    public void atualizarSalario(float novoSalario)
    {
        salarioAtual = novoSalario;
        Console.WriteLine("Salario atualizado para: " + salarioAtual);
    }

    public void listarDependentes()
    {
        Console.WriteLine("Listando dependentes do funcionario...");
    }
}

class Program
{
    static void Main()
    {
        Funcionario f = new Funcionario();

        Console.Write("Digite a matricula: ");
        f.matricula = int.Parse(Console.ReadLine());

        Console.Write("Digite o nome: ");
        f.nome = Console.ReadLine();

        Console.Write("Digite o cargo: ");
        f.cargoAtual = Console.ReadLine();

        Console.Write("Digite o salario: ");
        f.salarioAtual = float.Parse(Console.ReadLine());

        Console.WriteLine();

        f.cadastrar();
        f.consultar();

        Console.WriteLine();
        Console.Write("Digite o novo salario: ");
        float novo = float.Parse(Console.ReadLine());

        f.atualizarSalario(novo);

        Console.WriteLine();
        f.listarDependentes();
    }
}
