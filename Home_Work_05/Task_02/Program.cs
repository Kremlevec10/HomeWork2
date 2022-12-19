// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine(summOddElements());

static int summOddElements() {
    int[] arr = fillByArr(greatArr(getLengthByArr()));

    int summ = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            summ = summ + arr[i];
        } 
    }
    return summ;
}

static int getLengthByArr() {
    
    int lengthArr = new Random().Next(1,101);
    return lengthArr;
}

static int[] fillByArr(int[] arr) {
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1,101);
    }
    return arr;
}

static int[] greatArr(int length) {
    return new int[length];
}