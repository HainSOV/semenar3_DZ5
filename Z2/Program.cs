static void Main()
{
    // Задаем размер массива
    int arrayLength = 10;

    // Создаем экземпляр генератора случайных чисел
    Random random = new Random();

    // Создаем массив и заполняем его случайными положительными трехзначными числами
    int[] array = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
     {
        array[i] = random.Next(100, 1000);
    }

    // Выводим исходный массив на экран
    Console.WriteLine("Исходный массив:");
    PrintArray(array);

    // Находим количество четных чисел в массиве
    int evenNumbersCount = CountEvenNumbers(array);

    // Выводим результат
    Console.WriteLine($"Количество четных чисел в массиве: {evenNumbersCount}");
}

static void PrintArray(int[] array)
{
    foreach (var element in array)
     {
        Console.Write(element + " ");
    }
    Console.WriteLine();
}

static int CountEvenNumbers(int[] array)
{
    int count = 0;
    foreach (var number in array)
    {
        if (number % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
int[] array = new int[arrayLength];
for (int i = 0; i < arrayLength; i++)
{
    array[i] = random.Next(100, 1000);
}
Console.WriteLine("Исходный массив:");
PrintArray(array);
int evenNumbersCount = CountEvenNumbers(array);
static int CountEvenNumbers(int[] array)
{
    int count = 0;
    foreach (var number in array)
    {
        if (number % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine($"Количество четных чисел в массиве: {evenNumbersCount}");


