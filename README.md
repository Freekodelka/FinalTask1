# FinalTask1
﻿/* Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */


string[] array = {"-267", "n881", "nhvj", "gr321", "87000"}; //Задаем исходный массив строк
int n = 3;                                                   // Задаем произвольное число, количество символов которое будем передовать в новый массив                                         
string [] NewArray = new string [array.Length];              // Задаем новый массив в который будем копировать символы из исходного массива
int j = 0; 
for (int i = 0; i < array.Length; i++)                       // Проходим по исходному массиву, проверяем элементы массива
{

    if (array[i].Length <= n)                               // Если количество символов в элементе исходного массива меньше либо равно n(в данном случае n=3), 
                                                            //  копируем элемент исходного массива в новый массив, иначе в новый массив копируется пустой элемент (Null)
    {                                                                                          
        NewArray[j] = array[i];                         
        j++; 
    }
        
}
string [] ResultArray = new string [j];                     //Создаем массив с результатом, в который будем копировать елементы из нового массива без путых символов                

for (int i = 0; i < j; i++)
{
    ResultArray[i] = NewArray[i];
} 

Console.Write($"{String.Join(',', ResultArray)}");           //Выводим в окно терминала результат

if (ResultArray.Length ==0 )                                 // Добавляем проверку, если у всего исходного массива нет элементов в котором меньше либо равно трех элементов
{                                                            //То выводим в окно терминала символы "[]"
    Console.WriteLine("[]");
}
