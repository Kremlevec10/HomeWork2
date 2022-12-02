// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine(GetNumberByIndexTwo(GetNumber()));


int GetNumber() {
    int number;
    do
    {
        Console.WriteLine("Введите 3-х значное число ");
        number = int.Parse(Console.ReadLine()??"");
    } while (number < 100 || number > 999);
    return number;
}

int GetNumberByIndexTwo(int number) {
    int numberByIndexTwo = (number / 10) % 10;
    return numberByIndexTwo;
}





