// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] EnterArray()
{
    Console.Write("Enter length of array: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int[] arr = new int[number];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(99, 1000);
    }
    Console.WriteLine($"You Array: {String.Join(", ", arr)}");
    return arr;
}

void NumberOfEvenElements(int[] arr)
{
    int count =0;
    for(int i=0;i<arr.Length;i++)
    {
        if(arr[i]%2==0)
        {
            count++;
        }
    }
    Console.WriteLine($"Count even elements:\t" + count);
}
NumberOfEvenElements(EnterArray());
