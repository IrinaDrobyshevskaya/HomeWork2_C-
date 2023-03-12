//Задача 10: Напишите программу, которая принимает на 
//вход трёхзначное число и на выходе показывает вторую 
//цифру этого числа.
//456 -> 5
//782 -> 8 

/* Console.WriteLine("Ведите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int result = (number/10)%10;

Console.WriteLine(result); */


//Задача 13: Напишите программу, которая выводит третью
//цифру заданного числа или сообщает, 
//что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

/* Console.WriteLine("Ведите число");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);

if (numberText.Length > 2)
{
    Console.WriteLine("Третья цифра - " +numberText[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}  */


//Задача 15: Напишите программу, которая принимает на 
//вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
//6 -> да 
//7 -> да 
//1 -> нет

Console.WriteLine("Ведите номер дня недели");
int number =Convert.ToInt32(Console.ReadLine());

if (number<1 && number>7)
{
    Console.WriteLine("Введено неверное число.");
}
else if (number >=1 && number<=5)
{
    Console.WriteLine("Данный день является рабочим.");
}
else if (number>5 && number <7)
{
    Console.WriteLine("Днный день является выходным.");
}