// Задача № 41. Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.

using static System.Console;
Clear();

WriteLine("Введите числа через пробел: ");
int[] array = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToArray();
int result = countingNumbers(array);
WriteLine(result);

int countingNumbers(int[] array1)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] > 0) count++;
    }
    return count;
}




