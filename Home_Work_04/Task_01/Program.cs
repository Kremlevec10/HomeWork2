// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


degreeNumberA(getNumberOne(),getNumberTwo());


static string getMessege(string str) {
    Console.WriteLine($"Введите {str} число");
    string messege = Console.ReadLine()??"";
    return messege; 
}

static int getNumberOne() {
    int number = 0;
    while(!(int.TryParse(getMessege("первое")??"",out number)) || number == 0) {
        Console.WriteLine("Вы ввели не верный формат , число не должно быть равно нулю");
    }
    return number;
}

static int getNumberTwo() {
    int number = 0;
    while(!(int.TryParse(getMessege("второе")??"",out number)) || number < 0 || number == 0) {
        Console.WriteLine("Вы ввели не верный формат , число не должно быть меньше либо равно нулю");
    }
    return number;
}

static void degreeNumberA(int numberA, int numberB) {
    int number = numberA;
    for (int i = 1; i < numberB; i++)
    {
        number = number * numberA;
    }
    Console.WriteLine($"число {numberA} в степени {numberB} = {number}");
}
