// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21



int[] array = new int[5];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    
}
void ChangeElements(int[] arr)
{
    Console.WriteLine($"You origin Array: {String.Join(", ", arr)}");

    for (int j = 0; j < arr.Length-1-j; j++)
    {
            arr[j] = arr[j] * arr[arr.Length-1-j];
    }
    

    Console.WriteLine($"You revert Array: {String.Join(", ", arr)}");
  
}

ChangeElements(array);
