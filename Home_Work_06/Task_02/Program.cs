// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

searchCross(getPoint(), getPoint(), getPoint(), getPoint());

static void searchCross(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1*x + b1;
    Console.WriteLine("Прямые пересекаются в точке (" + x + ";" + y + ")");
}

static string getMessege()
{
    Console.WriteLine("Введите координату прямой");
    return Console.ReadLine();
}

static double getPoint()
{
    double point = 0;
    while (true)
    {
        string messege = getMessege();
        if (double.TryParse(messege ?? "",out point))
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не число");
        }
    }
    return point;
}