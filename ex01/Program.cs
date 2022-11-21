// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

void ChangeStrings(int m, int n)
{
    int[,] myMatrix = GenerateMatrix(m, n);
    PrintMatrix(myMatrix);
    int temp = 0;
    int i = 0;
    for (int j = 0; j < n; j++)
    {
        temp = myMatrix[i, j];
        myMatrix[i, j] = myMatrix[m - 1, j];
        myMatrix[m - 1, j] = temp;
    }

    Console.WriteLine("после замены: ");
    PrintMatrix(myMatrix);
}

Console.Write("Введите количество строк ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine()!);

ChangeStrings(m, n);

// перемешиваем матрицу построчно/повертикально
void RevertMatrix(int m, int n)
{
    int[,] myMatrix = GenerateMatrix(m, n);
    // int[] myMatrix2 = myMatrix.Clone();
    int[,] myMatrix2 = new int[m,n];
    PrintMatrix(myMatrix);

    // проверяем на четность

    for (int i=0; i<m;i++)
    {
        for (int j=0; j<n;j++)
        {

            myMatrix2[i,j] = myMatrix[j,i];

        }
    }
}
Console.WriteLine("после замены: ");
PrintMatrix(myMatrix2);


Console.Write("Введите количество строк ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine()!);

if (m==n) RevertMatrix(m,n);
else Console.Write("Замена невозможна");
