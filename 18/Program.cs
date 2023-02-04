﻿// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Clear();
Console.Write("Введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine());

switch (quarter)
{
    case 1:
        {
            Console.WriteLine("x>0 y>0");
            break;
        }
    case 2:
        {
            Console.WriteLine("x<0 y>0");
            break;
        }
    case 3:
        {
            Console.WriteLine("x<0 y<0");
            break;
        }
    case 4:
        {
            Console.WriteLine("x>0 y<0");
            break;
        }
    default:
        {
            Console.WriteLine("Введена неправильная четверть");
            break;
        }
}

/*Console.Write("Введите номер четверти: ");
int a = int.Parse(Console.ReadLine());

if (a == 1) {
    Console.WriteLine("X от 0 до бесконености, Y от 0 до бесконечности");
}

if (a == 2) {
    Console.WriteLine("X от 0 до -бесконености, Y от 0 до бесконечности");
}
if (a == 3) {
    Console.WriteLine("X от 0 до -бесконености, Y от 0 до -бесконечности");
}
if (a == 4) {
    Console.WriteLine("X от 0 до бесконености, Y от 0 до -бесконечности");
}*/