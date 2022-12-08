// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
string messeg = getMesseg();
int number = getNumberFromMesseg(messeg);
Console.WriteLine(checkPolindrom(number));


static string getMesseg() {
    bool isCorrect = false;
    string str = "";
    while(!isCorrect) {
    Console.WriteLine("Введите пятизначное число");
    str = Console.ReadLine();
    if(str.Length == 5) {
        isCorrect = true;
        } 
    }
    return str;
}

static int getNumberFromMesseg(string messeg) {
    int number = 0;
    bool isCorrect = false;
    while(!isCorrect) {
        isCorrect = int.TryParse(messeg??"", out number);
        if(!isCorrect) {
            Console.WriteLine("Вы ввели не число");
            messeg = getMesseg();
        }

    }
   return number;
}

static bool checkPolindrom(int number) {
    int divider = 10000;
    bool isPolindrom = true;
    while(number>10) {
        int firstNumber = number/divider;
        int lastNumber = number%10;
        isPolindrom = isPolindrom && firstNumber == lastNumber;
        Console.WriteLine(isPolindrom);
        number = (number%divider)/10;
        divider= divider/100;
        Console.WriteLine(number);
    }
    return isPolindrom;
}
