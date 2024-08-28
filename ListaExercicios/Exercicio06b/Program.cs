using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int tamanho = 100;
        int[] array = new int[tamanho];

        // Preenchendo o array com números aleatórios
        for (int i = 0; i < tamanho; i++)
        {
            array[i] = random.Next(1, 1001); // Números aleatórios de 1 a 1000
        }

        Console.WriteLine("Array antes da ordenação:");
        ImprimirArray(array);

        // Ordenando o array usando Array.Sort
        Array.Sort(array);

        Console.WriteLine("\nArray após a ordenação:");
        ImprimirArray(array);
    }

    static void ImprimirArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
