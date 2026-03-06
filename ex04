class Funcionario
{
    public int matricula;
    public string nome;
    public string cargoAtual;
    public float salarioAtual;

    public void cadastrar()
    {
        Console.WriteLine("Método cadastrar executado.");
        Console.WriteLine("Cadastro de funcionário realizado.");
    }

    public void consultar()
    {
        Console.WriteLine("Método consultar executado.");
        Console.WriteLine($"Matrícula: {matricula}");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Cargo: {cargoAtual}");
        Console.WriteLine($"Salário: {salarioAtual}");
    }

    public void atualizarSalario(float novoSalario)
    {
        salarioAtual = novoSalario;
        Console.WriteLine($"Salário atualizado para: {novoSalario}");
    }

    public void listarDependentes()
    {
        Console.WriteLine("Método listarDependentes executado.");
        Console.WriteLine("Listando dependentes do funcionário...");
    }
}

class Program
{
    static void Main()
    {
        Funcionario f1 = new Funcionario();

        f1.matricula = 101;
        f1.nome = "Carlos";
        f1.cargoAtual = "Analista";
        f1.salarioAtual = 3500;

        f1.cadastrar();
        f1.consultar();
        f1.atualizarSalario(4200);
        f1.listarDependentes();
    }
}
