// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

void SumOfOddElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Count even elements:\t" + count);
}
NumberOfEvenElements(EnterArray());

