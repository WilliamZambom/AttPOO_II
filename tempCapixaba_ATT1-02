double soma = 0;
double temperatura;

for (int dia = 1; dia <= 15; dia++)
{
    Console.Write($"Digite a temperatura do dia {dia}: ");
    temperatura = double.Parse(Console.ReadLine());

    if (temperatura <= 28)
    {
        Console.WriteLine("Temperatura inválida para o verão capixaba. Digite novamente.");
        dia--;
        continue;
    }

    soma += temperatura;
}

double media = soma / 15;

Console.WriteLine($"Temperatura média do verão capixaba: {media} °C");
