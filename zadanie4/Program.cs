// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] EnterArray()
{
    Console.Write("Enter length of array: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int[] arr = new int[number];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
    Console.WriteLine($"You Array: {String.Join(", ", arr)}");
    return arr;
}


void DiffOfMaxMinNumbers(int[] arr)
{
    int min = 100; int max = 0;
    for (int i = 0; i < arr.Length; i++)
    {

        if (arr[i] < min)
        {
            min = arr[i];
        }
        else
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }

        }
    }
    System.Console.WriteLine($"Diff of max&min elements {max - min}");

}

DiffOfMaxMinNumbers(EnterArray());



