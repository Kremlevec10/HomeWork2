// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// 
// [345, 897, 568, 234] -> 2

int[] arr = fillByArr(greatArr(getLengthByArr()));
Console.WriteLine(parityCheck(arr));

static int parityCheck(int[] arr) {
    int countParity = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            countParity++;
        }
    }
    return countParity;
}

static int getLengthByArr() {
    
    int lengthArr = new Random().Next(1,101);
    return lengthArr;
}

static int[] fillByArr(int[] arr) {
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100,1000);
    }
    return arr;
}

static int[] greatArr(int length) {
    return new int[length];
}