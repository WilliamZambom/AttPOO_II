int A = 0;
int B = 0;
int C = 0;
int D = 0;
int E = 0;

int idade;
int total = 0;


Console.Write("Digite as idades (digite 0 ou negativo para encerrar):  ");
idade = int.Parse(Console.ReadLine());

while (idade != 0){
   
    if (idade >= 1 && idade <= 15)
    {
        A++;
    } else if (idade <= 30)
    {
        B++;
    }
    else if (idade <= 45)
    {
        C++;
    }
    else if (idade <= 60)
    {
        D++;
    }else
    {
        E++;
    }

    total++;
    Console.Write("Digite aqui: ");
    idade = int.Parse(Console.ReadLine());
}

if (total > 0)
{
    Console.WriteLine("Porcentagens:");

    Console.WriteLine($"Faixa A: {(A * 100.0) / total}%");
    Console.WriteLine($"Faixa B: {(B * 100.0) / total}%");
    Console.WriteLine($"Faixa C: {(C * 100.0) / total}%");
    Console.WriteLine($"Faixa D: {(D * 100.0) / total}%");
    Console.WriteLine($"Faixa E: {(E * 100.0) / total}%");
}
