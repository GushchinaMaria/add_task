/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

 */

string [] array = new string[] {"1234","run","-2","bigger"};//{"Sun", "Mon", "Tue", "Wed"};
int count = 0;

foreach (var item in array)
{
    if (item.Length <= 3)
    {
        count ++;
    }
}
string [] res_arr = new string[count];
count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <=3)
    {
        res_arr[count] = array[i];
        count++;
    }
}

Console.WriteLine(String.Join (",", res_arr));
