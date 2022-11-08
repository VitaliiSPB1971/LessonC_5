// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях
Console.Write($"Введите размерность массива:");
int size = Convert.ToInt32(Console.ReadLine());
int randomArray(int size)
{
    int count = 0;
    int[] arr = new int[size];
    Console.Write("Массив значений:");
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(0, 1000);
        if (i % 2 != 0)
        {
            count = count + arr[i];
        }
        Console.Write("{0} ", arr[i]);
    }
    return count;
}
int countResult = randomArray(size);
Console.WriteLine($"\r\nСумма элементов на нечетных позициях: {countResult} ");
