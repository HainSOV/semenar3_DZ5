static void Main()
{
    // Задаем размер массива
    int arrayLength = 10;

    // Создаем экземпляр генератора случайных чисел
    Random random = new Random();

    // Создаем массив и заполняем его случайными вещественными числами
    double[] array = new double[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = random.NextDouble() * 100; // генерируем числа от 0 до 100
    }

    // Выводим исходный массив на экран
    Console.WriteLine("Исходный массив:");
    PrintArray(array);

    // Находим максимальный и минимальный элементы массива
    double maxElement = array[0];
    double minElement = array[0];
    foreach (var element in array)
    {
        if (element > maxElement)
        {
            maxElement = element;
        }

        if (element < minElement)
        {
            minElement = element;
        }
        }

    // Находим разницу между максимальным и минимальным элементами массива
    double difference = maxElement - minElement;

    // Выводим результат
    Console.WriteLine($"Максимальный элемент: {maxElement}");
    Console.WriteLine($"Минимальный элемент: {minElement}");
    Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
}

static void PrintArray(double[] array)
{
    foreach (var element in array)
    {
        Console.Write(element + " ");
    }
    Console.WriteLine();
}

double[] array = new double[arrayLength];
for (int i = 0; i < arrayLength; i++)
{
    array[i] = random.NextDouble() * 100; // генерируем числа от 0 до 100
}
Console.WriteLine("Исходный массив:");
PrintArray(array);
double maxElement = array[0];
double minElement = array[0];
foreach (var element in array)
{
    if (element > maxElement)
    {
        maxElement = element;
    }

    if (element < minElement)
    {
        minElement = element;
    }
}
double difference = maxElement - minElement;
Console.WriteLine($"Максимальный элемент: {maxElement}");
Console.WriteLine($"Минимальный элемент: {minElement}");
Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
