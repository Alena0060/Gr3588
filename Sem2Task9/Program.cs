//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8

//Создаем экземпляр класса рандомайзер
System.Random numberSintezator = new System.Random();

//Получаем новое случайное число
int number = numberSintezator.Next(10,100);

//Выводим данные в консоль
Console.WriteLine(number);

//Получаем первое и второе число по отдельности
int firstNumber = number/10;
int secondNumber = number%10;

//Сравниваем числа
if(firstNumber>secondNumber)
{
    //Выводим данные в консоль
    Console.WriteLine(firstNumber);
}
else
{
    //Выводим данные в консоль
    Console.WriteLine(secondNumber);
}
