// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве;
// A (3,6,8); B (2,1,-7), -> 15.84;

int Input(string output) // Фун-я на введение чисел
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int Razn (int a, int b) // Фун-я на разность
{
    return a - b;
}

int Cube (int a) // Фун-я на куб
{
    return a * a;
}

int x1 = Input("Введите координату x1: ");
int y1 = Input("Введите координату y1: ");
int z1 = Input("Введите координату z1: ");

int x2 = Input("Введите координату x2: ");
int y2 = Input("Введите координату y2: ");
int z2 = Input("Введите координату z2: ");

int lineX = Razn(x2,x1);
int lineY = Razn(y2,y1);
int lineZ = Razn(z2,z1);

Console.WriteLine(Math.Sqrt(Cube(lineX) + Cube(lineY) + Cube(lineZ)));

