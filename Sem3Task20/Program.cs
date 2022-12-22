// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

int ReadData(string msg)
{
Console.WriteLine(msg);
return int.Parse(Console.ReadLine() ?? "0");
}

int xh = ReadData("input xh: ");
int xv = ReadData("input xv: ");
int yh = ReadData("input yh: ");
int yv = ReadData("input yv: ");

double CalculateLength(int x1, int x2, int y1, int y2)
{
double res = 0;
res = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
return res;
}


void PrintData(string msg, double result)
{
Console.WriteLine(msg + result);
}

PrintData("Distance between points ", CalculateLength(xh, xv, yh, yv));