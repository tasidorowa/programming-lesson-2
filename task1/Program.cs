﻿// в с# массивы имеют значения по умолчанию/ если
// числовой массив, то нули
int[] arr = new int[5]; // создан массив из 5 жлементов
arr[0] = 5;
arr[1] = 7;
arr[2] = 19;
arr[3] = 4;
arr[4] = 8;

for (int i = 0; i < 5; i++)
    Console.Write(arr[i] + " ");

int[] arr2 = new int[5] { 1, 2, 4, 8, 12 }; // правая кнопка мыши - document format

int arr3 = { 1, 5, 12, 67, 9 };
