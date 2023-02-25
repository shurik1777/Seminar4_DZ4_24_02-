/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

Используйте NextDouble().
*/
double[] CreateArrayRealRandom(int size, int minValue, int maxValue)
// Создание массива, заполненного случайными числами c Double
{
    double[] result = new double[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 1, MidpointRounding.AwayFromZero);
        // Math.Round метод в сочетании с перечислением MidpointRounding .AwayFromZero приминил с офф. документации для округления
        // Остальное переделал Next на NextDouble умножаем на (максимальное минус минимальное) плюс минимальное возвращаем результат
    }
    return result;
}
double FindTheMinValueArray(double[] array)
// Ищем минимальный элемент в массиве.
{
    double minValue = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minValue) minValue = array[i];
    }
    return minValue;
}

double FindTheMaxValueArray(double[] array)
// Ищем максимальный элемент в массиве.
{
    double maxValue = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxValue) maxValue = array[i];
    }
    return maxValue;
}


double FindDifference(double min, double max)
// Ищем разности двух вещественных чисел.
{
    double result = 0;
    if (min < max)
    {
       result = max - min;
    } 
    else 
    {
        result = min - max;
    }
    return result;
}

double[] array = CreateArrayRealRandom(5, 0, 99);
// По примеру 5 - количество индексов, 0 - начальный диапазон, 99 - конечный диапазон для 2х цифр.
Console.WriteLine(String.Join("; ", array));
Console.WriteLine();
// Выводим массив делаем пустую строку для читаемости.
double MinValue = FindTheMinValueArray(array);
Console.WriteLine($"Минимальный элемент в массиве равен: {MinValue}");

double MaxValue = FindTheMaxValueArray(array);
Console.WriteLine($"Максимальный элемент в массиве равен: {MaxValue}");

double Difference = Math.Round(FindDifference(MinValue, MaxValue), 1, MidpointRounding.AwayFromZero);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна: {Difference}");
// Выводим разницу между элементами делаем пустую строку для читаемости.