// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] arr = {4,6,7,3,1,6};
printArr(arr);

static void printArr(int[] arr) {
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
        if (i == arr.Length - 1)
        {
        Console.Write(arr[i]);  
        }
    }
    Console.Write("]");
}