﻿int Max(int arg1, int arg2, int arg3)  
// задаём три аргумента, в них будут записываться значения сравниваемых чисел
{
    int result = arg1; // для начала считаем первый аргумент максимальным
    if (arg2 > result) result = arg2; // если второй элемент больше, то максимальным становится он
    if (arg3 > result) result = arg3; // если третий аргумент больше, то максимальным становится он
    return result; // возвращаем максимальное из трёх
}


// Определяем массив:
// в контейнер для целых чисел помещаем массив, называем его array и записываем в него числа
int[] array = { 14, 62, 83, 43, 52, 67, 73, 48, 59 };
//индексы чисел: 0   1   2   3   4   5   6   7   8


int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])
);
   
Console.WriteLine(max);