/*
Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int[] CreateArrayRandom(int size, int minValue, int maxValue)
// Создание массива, заполненного случайными числами спасибо семинару
{
    int[] result = new int[size]; // Создание массива на size элементов
    for (int i = 0; i < result.Length; i++) // result.Length = size
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
    // Возвращаю результат в CreateArrayRandom массив
}
int AmountOfEvenNumbers(int[] array)
// Метод, по которому нужно вычислить (количество четных чисел в англ. переводе) в массиве
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) amount++;
    }
    return amount;
}
int[] array = CreateArrayRandom(5, 100, 999);
// Массиву array присвоил 5 - количество индексов, 100 - начальный диапазон, 999 - конечный диапазон.
int amount = AmountOfEvenNumbers(array);
// Так как это глобальный, а не локальный параметр - то могу создать параметр с точно таким же названием
// как и в теле метода AmountOfEvenNumbers и присвоить ему диапазон массива этого же метода!
Console.WriteLine(String.Join("; ", array));
// Добавляю все значения в строки и присваиваю им делитель ; + пробел для красоты
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве равно: {amount}");
// B конечном итоге вывожу результат верной суммы диапазона.