
int[] array = [3, 5, 12, 78, 45, 23, 5, 9, 11, 56];
int i = 0;

while (i < array.Length)
{
    if (array[i] % 2 == 0) Console.Write($"{array[i]} "); // control + c - остановить выполнение
    i++;
}