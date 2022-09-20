// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int SumNegativElements(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i=i+2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int[] array = GetArray(6, 0, 100);
Console.WriteLine(string.Join(",", array));
int SumNegativ = SumNegativElements(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позицих = {SumNegativ}");