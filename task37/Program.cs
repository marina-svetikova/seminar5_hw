// // Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] arr = {1, 2, 3, 4, 5};
int[] arrnew = new int [(arr.Length+1)/2]; //(7+1)/2=4; (4+1)/2=2
for (int i=0; i<arrnew.Length;i++)
{
    arrnew [i] = arr[i]*arr[arr.Length -1-i];
}
if(arr.Length%2!=0)
{
    arrnew[arrnew.Length-1]=arr[arr.Length/2];
}
Console.Write(string.Join(", ",arrnew));


