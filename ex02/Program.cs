// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int[,] CreateArray(int rows, int columns)
{
    var random = new Random();

    int[,] array = new int[rows, columns];

    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0, 16);
        }
    }

    return array;
}

void PrintFrequences(int[] input)
{
    for (var i = 0; i < input.Length; i++)
    {
        if (input[i] != 0)
            Console.WriteLine($"Элемент {i} встречается {input[i]} раз");
    }
    Console.WriteLine();

}

void Print2DArray(int[,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            Console.Write(input[i, j]);

            if (j != input.GetLength(1) - 1)
                Console.Write(", ");
        }
        Console.WriteLine();
    }
}

int FindMax(int[,] input)
{
    int result = input[0, 0];

    for (int i = 0; i < input.GetLength(0); i++)
        for (int j = 0; j < input.GetLength(1); j++)
            if (input[i, j] > result)
                result = input[i, j];

    return result;
}

int[] CountFrequences(int[,] input)
{
    int[] result = new int[FindMax(input) + 1];

    for (int i = 0; i < input.GetLength(0); i++)
        for (int j = 0; j < input.GetLength(1); j++)
            result[input[i, j]]++;

    return result;
}

var array = CreateArray(3, 4);

Print2DArray(array);

var frequences = CountFrequences(array);

PrintFrequences(frequences);
