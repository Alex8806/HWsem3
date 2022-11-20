// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Введите x первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите z первой точки");
int z1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите x второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите z второй точки");
int z2 = Convert.ToInt32(Console.ReadLine());

int TotalX = x1-x2;

int TotalY = y1-y2;

int TotalZ = z1-z2;
double lenght =Math.Round( Math.Sqrt (Math.Pow(TotalX,2)+Math.Pow(TotalY,2)+Math.Pow(TotalZ,2)),2);
System.Console.WriteLine(lenght);