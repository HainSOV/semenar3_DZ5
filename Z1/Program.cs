    static void Main()
    {
        // Задаем размер массива
        int arrayLength = 10;

        // Создаем экземпляр генератора случайных чисел
        Random random = new Random();

        // Создаем массив и заполняем его случайными числами от 1 до 100
        int[] array = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            array[i] = random.Next(1, 101);
        }

        // Выводим исходный массив на экран
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Находим сумму элементов на нечетных позициях
        int sumOfOddPositionElements = 0;
        for (int i = 1; i < arrayLength; i += 2)
        {
            sumOfOddPositionElements += array[i];
        }

        // Выводим результат
        Console.WriteLine($"Сумма элементов на нечетных позициях: {sumOfOddPositionElements}");
    }

    static void PrintArray(int[] array)
    {
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

