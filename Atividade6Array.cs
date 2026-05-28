
/*
int[] ordenar = new int[5];
{
    for (int x = 0; x < 5; x++)
    {
        Console.WriteLine($"Digite o {x + 1}º numero: ");
        ordenar[x] = int.Parse(Console.ReadLine()!);

    }

    for (int x = 0; x < 5; x++)
    {
        for (int y = x + 1; y < 5; y++) //posso iniciar y = 1, resolve o problema
        {
            if (ordenar[x] > ordenar[y])
            {
                int aux = ordenar[x];
                ordenar[x] = ordenar[y];
                ordenar[y] = aux;
            }
        }
    }

    Console.WriteLine("Numeros ordenados");

    for (int x = 0; x < 5; x++)
    {
        Console.Write($"{x + 1}º numero: {ordenar [x]}");
    }
}
*/