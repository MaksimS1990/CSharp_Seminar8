//пример с оператором foreach

int[,] array = CreateArray(3, 4);   // функция отсутствует в данном коде(ЭТО ПРОСТО ПРИМЕР)

Print2DArray(array);

Console.WriteLine();

foreach (var element in array)
{
    Console.Write(element + " ");
}
