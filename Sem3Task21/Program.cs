// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = ReadInt("Enter the X coordinate of the first point: ");
int y1 = ReadInt("Enter the Y coordinate of the first point: ");
int z1 = ReadInt("Enter the Z coordinate of the first point: ");
int x2 = ReadInt("Enter the X coordinate of the second point: ");
int y2 = ReadInt("Enter the Y coordinate of the second point: ");
int z2 = ReadInt("Enter the Z coordinate of the second point: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Length of the segment {length}");


// Функция ввода сообщения
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
