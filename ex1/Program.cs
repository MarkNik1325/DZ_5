//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

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

int ParitiNumber (int [] array)
{
int sum = 0;
for (int i = 0; i<array.Length; i++)
{
if (array[i] % 2 == 0)
sum = sum + 1;
}
return sum;
}

int length = ReadInt ("Введите длину массива");
int min = 100;
int max = 1000;
int[] array = GetRandomArray(length, min, max);
PrintArray (array);
Console.WriteLine ();
Console.WriteLine ($"В данном массиве содержится {ParitiNumber(array)} четных чисел ");

