// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
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
        arr[i] = rand.Next(100, 999);
        if (arr[i] % 2 == 0)
        {
            count++;
        }
        Console.Write("{0} ", arr[i]);
    }
    return count;
}
int countResult = randomArray(size);
Console.WriteLine($"\r\nКоличество четных чисел: {countResult} ");
