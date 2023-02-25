/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int[] CreateArrayRandom(int size, int minValue, int maxValue)
// Создание массива, заполненного случайными числами
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
int SumOfElementsInOddPositions(int[] array)
// Метод, по которому нужно в диапазоне массива найти сумму нечетных индексов 
{
    int sum = 0; // стартую сумму с нуля
    for (int i = 1; i < array.Length; i += 2)
    // начинаю счетчик с 1, условие, меняю значение переменной i 
    {
        sum += array[i];
    }
    return sum;
    // Возвращаю результаты
}
int[] array = CreateArrayRandom(4, -10, 20);
// По примеру 4 - количество индексов, -10 - начальный диапазон, 20 - конечный диапазон.
int summ = SumOfElementsInOddPositions(array);
Console.WriteLine(String.Join("; ", array));
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечётных позициях равна: {summ}");