/* int[,] numeros = new int[2, 3];
int maior = 0;

for (int linha = 0; linha < 2; linha++)
{
    for (int coluna = 0; coluna < 3; coluna++)
    {
        Console.WriteLine($"Digite numero: ");
        numeros[linha, coluna] = int.Parse(Console.ReadLine()!);

    }
}
for (int linha = 0; linha < 2; linha++)
{
    for (int coluna = 0; coluna < 3; coluna++)
    {
        Console.WriteLine($"linha {linha}, coluna {coluna}: {numeros[linha, coluna]}");
        if (numeros[linha, coluna] > maior)
        {
            maior = numeros[linha, coluna];
        }
    }
}
Console.WriteLine($"O maior numero e: {maior}"); */