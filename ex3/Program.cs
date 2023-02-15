//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] GetRandomArray(int length, int min, int max)
{
    double [] array = new double [length];
    for (int counter = 0; counter < length; counter++)
    {
        array[counter] = Convert.ToDouble(new Random().Next(min,max));
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

void PrintArray (double [] array)
{
    for (int counter = 0; counter < array.Length; counter++)
{
Console.Write ($"{array[counter]}; ");
}
}

double FindMax (double [] array)
{
double max = 0;
for (int z = 0; z < array.Length; z++)
{   
    if (array[z] > max)
        {
            max = array[z]; 
        }
}
return max;
}

double FindMin (double [] array)
{
int z = 0;
double Min = array [z];
while (z < array.Length)
{
if (array[z] < Min)
Min = array[z];
z++;    
}
return Min;
}


int length = ReadInt ("Введите длину массива");
int min = ReadInt ("Введите минимальное значение массива");
int max = ReadInt ("Введите максимальное значение массива");
double [] array = GetRandomArray(length, min, max);
PrintArray (array);
Console.WriteLine();
Console.WriteLine($"максимальное значение равно {FindMax (array)}");
Console.WriteLine($"минимальное значение   равно {FindMin (array)}");
Console.WriteLine($"Разность между максимальным и минимальным значениями равна {FindMax (array) - FindMin (array)}");





