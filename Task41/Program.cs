// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3



//Вариант решения с помощью массива, сначала спрашиваем у пользователя из какого количества чисел будет массив,
//Далее вводим каждый элемент массива с клавиатуры, и считаем количество чисел > 0.
Console.Clear();
Console.WriteLine("Какое количество чисел будем вводить? ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int M=0;
for (int i=0; i<size; i++)
{
    Console.Write($"Введите {i+1} число: ");
    array[i]=Convert.ToInt32(Console.ReadLine());
    if (array[i]>0) M=M+1;
} 
Console.WriteLine(String.Join(", ",array));
Console.WriteLine($"Больше 0 введено -> {M} ");