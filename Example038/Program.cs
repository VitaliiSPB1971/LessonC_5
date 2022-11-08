// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
Console.Write($"Введите размерность массива:");
int size = Convert.ToInt32(Console.ReadLine());
double[] randomArray(int size)
{
    double[] arr = new double[size];
    Console.Write("Массив значений:");
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = Convert.ToDouble(rand.Next(-100, 100) / 10.0);
        Console.Write("{0} ", arr[i]);
    }
    return arr;
}
double[] randMass = randomArray(size);
double difference(double[] array)
{
    double min = array[0];
    double max = array[0];
    foreach (double i in array)
    {
        if (min > i)
        {
            min = i;
        }
        if (max < i)
        {
            max = i;
        }
    }
    return max - min;
}
double result = difference(randMass);
Console.WriteLine($"\r\nРазница между максимальным и минимальным значениями: {result} ");
