int[] array = [6, 7, 12, 56, 8];
int max = array[0];
int i = 0;

while (i < array.Length)
{
    if (array[i] > max) max = array[i];
    i++;
}
Console.WriteLine(max);

max = array[0];
for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max) max = array[j];
}
Console.WriteLine(max);

// Рекомендации по использованию циклов
// for - когда нужно перебрать элементы массива для каких-либо целей, когда известна верхняя граница итераций
// while - когда не известная верхняя граница итерация, например посимвольное чтение файла
// while (true) - бесконечный символ
max = array[0];
foreach (int e in array) // тип данных должен совпадать с типом данных массива
{
    if (e > max) max = e; // элементы доступны только на чтение из-за того, что элементы каждый раз копируются в e
}
Console.WriteLine(max);

// с помощью foreach можно вывести элементы на экран, посчитать сумму или ср., поиск элементов