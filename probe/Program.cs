// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
//ввод цифр и запись их в массив
int[] inNumbers(int lotsNumber)
{
    int[] mNumbers = new int[lotsNumber];
    for (int i = 0; i < lotsNumber; i++)
    {
        Console.Write($"Введи число {i + 1}:  ");
        mNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    return mNumbers;
}
void PrintArray(int[] array)                    //вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write($"{array[i]}");
        }
        else
        {
            Console.Write($"{array[i]}, ");
        }
    }
}
int abZero(int[] array)                         // числа > 0
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
try
{
    Console.Write($"Введите количество чисел: ");
    int x = Convert.ToInt32(Console.ReadLine());

    int[] numbers = inNumbers(x);
    Console.Write($"Введеные числа: ");

    PrintArray(numbers);
    int result = abZero(numbers);
    Console.WriteLine("");
    Console.WriteLine($"Чисел больше 0 : {result} ");
}
catch
{
    Console.Write("Введеные данные не корректны.");
}