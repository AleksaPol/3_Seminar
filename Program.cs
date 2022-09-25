void Zadacha19()
//Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
{
    Console.WriteLine("_________________________");
    Console.WriteLine("Задача 19");
    Console.WriteLine("Введите любое пятизначное число:");
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    if (number < 100000 && number > 9999)
    {
        if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
        {
            Console.WriteLine("Введенное вами число - палиндром.");
        }
        else
        {
            Console.WriteLine("Введенное вами число - не палиндром.");
        }
    }
    else
    {
        Console.WriteLine("Вы вввели не пятизначное число, попробуйте снова!");
    }

}
Zadacha19();

void Zadacha21()
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
{
    Console.WriteLine("_________________________");
    Console.WriteLine("Задача 21");
    Console.WriteLine("Введите координаты точки A: ");
    Console.Write("X: ");
    int ax = Convert.ToInt32(Console.ReadLine());
    Console.Write("Y: ");
    int ay = Convert.ToInt32(Console.ReadLine());
    Console.Write("Z: ");
    int az = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки B: ");
    Console.Write("X: ");
    int bx = Convert.ToInt32(Console.ReadLine());
    Console.Write("Y: ");
    int by = Convert.ToInt32(Console.ReadLine());
    Console.Write("Z: ");
    int bz = Convert.ToInt32(Console.ReadLine());
    int k = bx - ax;
    int m = by - ay;
    int n = bz - az;
    double length = Math.Sqrt(k * k + m * m + n * n);
    length = Math.Round(length, 2);
    Console.WriteLine($"Длина между точками {length}.");
}
Zadacha21();

void Zadacha23()

//Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
{
    Console.WriteLine("_________________________");
    Console.WriteLine("Задача 23");
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Число\tКуб");
    int counter = 1;
    while (counter <= number)
    {
        double result = Math.Pow(counter, 3);
        Console.WriteLine($"{counter} : {result}");
        counter++;
    }

}
Zadacha23();