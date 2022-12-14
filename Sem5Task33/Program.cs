// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

//Заполняем массив
//int[] GenArray(int arrLength, int start, int stop)
//{
//    int[] array = new int[arrLength];
//    Random ren = new Random();

//    for (int i=0; i < arrLength; i++)
//    {
//        array[i] = ren.Next(start, stop + 1);
//    }
//    return array;
//}

//int[] GenArray(int len, int minValue, int maxValue)
//{
//    Random rnd = new Random();
//    int[] arr = new int[len];
//    for (int i = 0; i < arr.Length; i++)
//    {
//        arr[i] = new Random().Next(minValue, maxValue + 1);
//    }
//    return arr;
//}

//Печатает одномерный массив
//void Print1DArr(int[] arr)
//{
//    for (int i = 0; i < arr.Length - 1; i++)
//    {
//        Console.Write(arr[i] + ", ");
//    }
//    Console.WriteLine(arr[arr.Length - 1]);
//}
//Чтение данных из консоли
//int ReadData(string line)
//{
//Выводим сообщение
//    Console.WriteLine(line);
//Считываем число
//    int number = int.Parse(Console.ReadLine() ?? "0");
//Возвращаем значение
//    return number;
//}
//Печать результата
//void PrintData(string res, int value)
//    {
//        Console.WriteLine(res + value);
//    }

int[] array = GenArray(10, -9, 10);
Print1DArr(array);
int num = ReadData("input number");
int result = SearchElem(array, num);

if (result >= 0)
{
    PrintData("element found in positionЖ " + result);
}
else
{
    PrintData("the element was not found in the array!");
}
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

int[] GenArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

int SearchElem(int[] arr, int elem)
{
    int res = -1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == elem)
        {
            res = i;
            break;
        }
    }
    return res;
}