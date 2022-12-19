// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] arr = {3.0 , 7.0 , 22.0 , 2.0 , 78.0};
differenceMaxMin(arr);

static void differenceMaxMin(double[] arr) {
    double max = arr[0], min = arr[1];
    if (max < min) 
    {
        max = arr[1];
        min = arr[0];
    }
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
        } else if (min > arr[i])
        {
            min = arr[i];
        }
    }
    Console.WriteLine("Differense between Max and Min = " + (max - min));
}
