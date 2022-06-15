// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N;
// 3 -> 1, 8, 27;
// 5 -> 1, 8, 27, 64, 125;

int Cube (int a) //Фун-я на куб
{
    return a * a * a;
}
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count < n)
{
    int cub = Cube (count);
    count ++;
    Console.Write($"{cub}, ");
}
Console.WriteLine(Cube(n));
