// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
//[3 7 22 2 78] -> 76

int size = ReadInt("Enter the dimension of the array: ");
int min = ReadInt("Enter the minimum number of the array: ");
int max = ReadInt("Enter the maximum number of the array: ");
int [] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int maxFillarray = numbers[0];
int minFillarray = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > maxFillarray)
    {
        maxFillarray = numbers[i];
    }
    if (numbers[i] < minFillarray)
    {
        minFillarray = numbers[i];
    }
}
Console.WriteLine($"The difference between the maximum and minimum number = {maxFillarray - minFillarray}");

// Методы
void FillArrayRandomNumbers(int [] array) //Заполнение массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void PrintArray(int[] array) //Вывод массива на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)  //Функция ввода
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
