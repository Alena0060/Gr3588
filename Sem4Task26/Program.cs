// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

//Console.Write("input number: ");

//string? NumberStr = Console.ReadLine();
//int number = int.Parse(NumberStr??"0");

//Console.WriteLine((int)(1+Math.Log10(Number)));

int ReadData(string msg)
{
Console.WriteLine(msg);
return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
Console.WriteLine(res);
}

int VariantLog(int num)
{
int count = (int)Math.Log10(num)+1;
return count;
}
int number = ReadData("input number: ");
int length = VariantLog(number);
PrintData("The number of digits in the number is equal to " + length);



int VariantSimple(int num)
{
int count = 0;
for (int i=0; i<num; i++)
{
num=num/10;
count++;
}
return count;
}