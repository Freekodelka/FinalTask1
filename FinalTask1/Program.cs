/* Написать программу, которая из имеющегося массива строк 
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

string[] array = {"-267", "n881", "nhvj", "gr321", "87000"};
int n = 3;
string [] NewArray = new string [array.Length];
int j = 0; 
for (int i = 0; i < array.Length; i++)
{

    if (array[i].Length <= n)
    {    
        NewArray[j] = array[i];
        j++; 
    }
        
}
string [] ResultArray = new string [j];

for (int i = 0; i < j; i++)
{
    ResultArray[i] = NewArray[i];
} 

Console.Write($"{String.Join(',', ResultArray)}");

if (ResultArray.Length ==0 )
{
    Console.WriteLine("[]");
}

