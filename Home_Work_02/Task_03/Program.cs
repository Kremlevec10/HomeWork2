// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

checkHolliday(3);


void checkHolliday(int day) {
    switch (day)
    {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
            Console.WriteLine("нет");
            break;
        case 6:
            Console.WriteLine("да");
            break;
        case 7:
            Console.WriteLine("да");
            break;
    }

}
