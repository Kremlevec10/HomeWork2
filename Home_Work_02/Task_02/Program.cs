// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



Console.WriteLine(printNimberWithThreeIndex(GetNumber()));



string GetNumber() {
    Console.WriteLine("Введите  число ");
    return Console.ReadLine();
}

string printNimberWithThreeIndex(string number) {
    if(number.Length > 2) {
        return Convert.ToString(number.ToCharArray()[2]);
    } else {
        return "В этом числе нет третьей цифры";
    }
}


