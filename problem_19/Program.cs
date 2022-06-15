// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом;
// 14212 -> нет;
// 23432 -> да;
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int n1 = number / 1000; 
int n2 = number % 100;
int n3 = n2 % 10;
int n4 = n2 / 10;
string n5= ($"{n3}{n4}");
int n6 = Convert.ToInt32(n5);

if (n1 == n6)
{
Console.WriteLine("Да,"+ number +" палиндром");
}
else
{
Console.WriteLine("Нет,"+ number +" не палиндром");
}

