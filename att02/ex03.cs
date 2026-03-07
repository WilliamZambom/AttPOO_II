using System;

class Pessoa
{
    public string nome;
    public string endereco;
    public string telefone;

    public virtual void exibirDados()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Endereco: " + endereco);
        Console.WriteLine("Telefone: " + telefone);
    }
}

class PessoaFisica : Pessoa
{
    public long cpf;
    public int estadoCivil;

    public override void exibirDados()
    {
        base.exibirDados();
        Console.WriteLine("CPF: " + cpf);
        Console.WriteLine("Estado Civil: " + estadoCivil);
    }
}

class PessoaJuridica : Pessoa
{
    public long cnpj;
    public string razaoSocial;
    public string nomeRepresentante;

    public override void exibirDados()
    {
        base.exibirDados();
        Console.WriteLine("CNPJ: " + cnpj);
        Console.WriteLine("Razao Social: " + razaoSocial);
        Console.WriteLine("Representante: " + nomeRepresentante);
    }
}

class Program
{
    static void Main()
    {
        PessoaFisica pf = new PessoaFisica();
        pf.nome = "Joao";
        pf.endereco = "Rua A";
        pf.telefone = "1111-1111";
        pf.cpf = 12345678900;
        pf.estadoCivil = 1;

        PessoaJuridica pj = new PessoaJuridica();
        pj.nome = "Empresa X";
        pj.endereco = "Rua B";
        pj.telefone = "2222-2222";
        pj.cnpj = 12345678000199;
        pj.razaoSocial = "Empresa X LTDA";
        pj.nomeRepresentante = "Maria";

        pf.exibirDados();
        Console.WriteLine();
        pj.exibirDados();
    }
}
