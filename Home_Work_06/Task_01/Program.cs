// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

checkNumber();

static string enterNumber()
{
    Console.Write("Введите число ");
    Console.Write("Если хоите выйти нажмите *q* ");
    string number = Console.ReadLine();
    return number;
}

static void checkNumber()
{
    int count = 0;
    while (true)
    {
        int check;
        string number = enterNumber();
        bool isCorect = int.TryParse(number??"",out check);
        if (number.Equals("q", StringComparison.InvariantCultureIgnoreCase))
        {
            Console.WriteLine("Вы ввели число больше нуля " + count + " раз");
            break;
        }
        if (isCorect && check > 0)
        {
            count++;
        } else if (!isCorect)
        {
            Console.WriteLine("Вы ввели не число");
        }
    }
}

