// // Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму 
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] GetArray(int size, int leftRange,int rightRange)
{
     int[] arr = new int[size];
     Random rand = new Random();
     for (int i=0; i < size; i++)
     {
        arr[i] = rand.Next(leftRange, rightRange+1);
     }
     return arr;
}

int SumPositivElements(int[] arr )
{
   int sum = 0;
   for (int i = 0; i < arr.Length; i++)
   {
     if (arr[i]>0) //если элемент положиетльный
     sum=sum + arr[i]; //копим сумму положительных элементов
   }
   return sum;
}

int SumNegativElements(int[] arr )
{
   int sum = 0;
   for (int i = 0; i < arr.Length; i++)
   {
     if (arr[i]<0) //если элемент отрицательный
     sum=sum + arr[i]; //копим сумму отрицательных элементов
   }
   return sum;
}

int[] array = GetArray(12,-9,9);
Console.WriteLine(string.Join(",",array));
int SumPositiv = SumPositivElements(array);
int SumNegativ = SumNegativElements(array);
Console.WriteLine($"Сумма положительных элеметов = {SumPositiv}, отрицательных элементов = {SumNegativ}");