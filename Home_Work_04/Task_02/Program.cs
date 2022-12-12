// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

getSumm();

static string getMessege() {
    Console.WriteLine("Введите число");
    string messege = Console.ReadLine()??"";
    return messege; 
}

static int getNumber() {
    int number = 0;
    while(!(int.TryParse(getMessege()??"",out number))) {
        Console.WriteLine("Вы ввели не верный формат , это не число ");
    }
    return number;
}

static void getSumm() {
    int summ = 0 , numberInput = getNumber(), numberOutput = numberInput;
    if (numberInput < 0)
    {
        numberInput = Math.Abs(numberInput);
    } else if(numberInput < 10) {
        summ = numberInput;
    }
    while (numberInput >= 10) {
        summ = summ + (numberInput % 10);
        numberInput = numberInput / 10;
        if (numberInput < 10)
        {
            summ = summ +  numberInput;
        }
    }
    Console.WriteLine($"Сумма всех чисел числа {numberOutput} = {summ}");
}