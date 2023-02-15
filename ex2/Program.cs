//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetRandomArray(int length, int min, int max)
{
    int[] array = new int [length];
    Random num = new Random();
    
    for (int counter = 0; counter < length; counter++)
    {
        array[counter] = num.Next(min, max + 1);
    }
    return array;
}

int ReadInt (string argumentName)
{
Console.WriteLine($"Input {argumentName}");
  int number = 0;

 while (!int.TryParse (Console.ReadLine(), out number))
 {
    Console.WriteLine("Its not number");
 }
return number;
}

void PrintArray (int [] array)
{
    for (int counter = 0; counter < array.Length; counter++)
{
Console.Write ($"{array[counter]} ");
}
}

int OddPosition (int [] array)
{
    int sum = 0;
    for (int counter = 0; counter < array.Length; counter++)
    {
    if (counter%2!=0)
    {
    sum = sum + array [counter];
    }
    }
return sum;
}

int length = ReadInt ("Введите длину массива");
int min = ReadInt ("Введите минимальное значение массива");
int max = ReadInt ("Введите максимальное значение массива");
int[] array = GetRandomArray(length, min, max);
PrintArray (array);
Console.WriteLine ();
Console.WriteLine ($"В данном массиве сумма чисел на нечетных позициях равна {OddPosition(array)}");
