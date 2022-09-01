/* /* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
 */
/* Console.WriteLine("Введите число от 10000 до 99999");
int a = int.Parse(Console.ReadLine());

if(a < 10000 || a > 99999)
{
Console.WriteLine("Введите число от 10000 до 99999");
}

else
{
int num1 = a/10000;
int num2 = a/1000%10;
int num4 = (a%100)/10;
int num5 = a % 10;

if (num1 == num5)
{
    if(num2 == num4)
    {
    Console.WriteLine("введенное число - палиндром");
    }
}
else
{
    Console.WriteLine("Введенное число не палиндром");
}
}  */

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/* Console.WriteLine("Ввудите координаты точки x1");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ввудите координаты точки y1");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ввудите координаты точки z1");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ввудите координаты точки x2");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ввудите координаты точки y2");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ввудите координаты точки z2");
int z2 = int.Parse(Console.ReadLine());

double x3 = Math.Pow(x2 - x1, 2);
double y3 = Math.Pow(y2 - y1, 2);
double z3 = Math.Pow(z2 - z1, 2);
double res = Math.Sqrt(x3 + y3+ z3);

Console.WriteLine (res); */
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/* Console.WriteLine("Введите число N - ");
int N = int.Parse(Console.ReadLine());
int Eventnumber = 1;
Console.Write("Ответ - ");
while(Eventnumber<=N)
{
    Console.Write(Math.Pow(Eventnumber, 3));
    Console.Write(";");
    Eventnumber ++;
}


 */