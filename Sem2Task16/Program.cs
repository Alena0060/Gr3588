// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
//5, 25 -> да
//-4, 16 -> да
//25, 5 -> да
//8,9 -> нет

//Console.WriteLine("is one number the square of the other ?");
//Console.Write("Enter the first number: ");
//int firstNumber;
//bool isNumber = int.TryParse(Console.ReadLine(), out firstNumber);
//validate(isNumber);

//Console.Write("Enter the second number: ");
//int secondNumber;
//isNumber = int.TryParse(Console.ReadLine(), out secondNumber);
//validate(isNumber);

//Console.WriteLine(isSqrt(firstNumber,secondNumber)? "Yes" : "No");

//void validate(bool isNumber){
//if (!isNumber){
//Console.WriteLine("You did not enter a number, the output");
//Environment.Exit(0);
//}
//}

//bool isSqrt(int a, int b){
//return (a*a == b) || (b*b == a) ;
//}

void Test(int i, int j)
{
    bool result = (i/j==j);

    if(result==true)Console.WriteLine(" the number "+i+" is the square of the number "+j);
    else Console.WriteLine(" the number "+i+" is not the square of the number "+j);
}
int number1 = int.Parse(Console.ReadLine()??"0");
int number2 = int.Parse(Console.ReadLine()??"0");

Test(number1,number2);
Test(number2,number1);
