// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
//выдаёт номер четверти плоскости, в которой находится эта точка.
//x=34; y=-30 -> 4
//x=2; y=4-> 1
//x=-34; y=-30 -> 3

int coordinateX = ReadDate("enter X coordinate");
int coordinateY = ReadDate("enter Y coordinate");
PrintQuterTest();

//Метод читает данные от пользователя
int ReadDate(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод определяет четверть по координатам точки
void PrintQuterTest()
{
    if (coordinateX > 0 && coordinateY > 0) Console.WriteLine("quarter point 1");
    if (coordinateX > 0 && coordinateY < 0) Console.WriteLine("quarter point 2");
    if (coordinateX < 0 && coordinateY < 0) Console.WriteLine("quarter point 3");
    if (coordinateX < 0 && coordinateY > 0) Console.WriteLine("quarter point 4");
}
