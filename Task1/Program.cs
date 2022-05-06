// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

System.Console.WriteLine("Введите любые натуральные числа через пробел:");
string a = Console.ReadLine();
string[] arr = a.Split(" ");
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    int some = int.Parse(arr[i]);
    if (some > 0) count++;
}
System.Console.WriteLine($"Кол-во чисел, значение которых больше 0: {count}");