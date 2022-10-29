﻿
/*//Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


 int[] array = GetArray(10, 100, 999);
 int count = 0;
 Console.WriteLine($"Вот массив:{String.Join(", ",array)}");
 for (int i = 0; i < array.Length; i++){
     if (array[i] % 2 == 0){
         count++;
     }

 }
 Console.WriteLine($"Количество четных чисел в массиве {count}");
 int[] GetArray(int size, int minValue, int maxValue)
 {
     int[] res = new int[size];

     for (int i = 0; i < size; i++)
     {
         res[i] = new Random().Next(minValue, maxValue + 1);

     }
     return res;
 }
 */

  //Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
 //[3, 7, 23, 12] -> 19
 //[-4, -6, 89, 6] -> 0

 int[] array1 = GetArray(10, 0, 10);
 int count = 0;
 Console.WriteLine($"Вот массив:{String.Join(", ",array1)}");
 for (int i = 1; i < array1.Length; i+=2){
     count = count + array1[i];
 }
 Console.WriteLine($"Сумма нечетных элементов {count}");


 int[] GetArray(int size, int minValue, int maxValue)
 {
     int[] res = new int[size];

     for (int i = 0; i < size; i++)
     {
         res[i] = new Random().Next(minValue, maxValue + 1);

     }
     return res;
 }