// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int count = 1;
int n = 1;
int index = 0;
double sqr = 0;
double[] result = new double[num];

while (num >= count){
    sqr = Math.Pow(n, 2);
    result[index] = sqr;
    Console.Write($" {result[index]}");
    n++;
    index++;
    count++;
}


/*
Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int count = 1;
int n = 1;
double sqr = 0;

while (num >= count){
    sqr = Math.Pow(n, 2);
    Console.Write($" {sqr}");
    n++;
    count++;
}
*/
