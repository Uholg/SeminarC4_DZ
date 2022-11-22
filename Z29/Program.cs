//Задача 29: Напишите программу, которая задаёт массив из N 
//элементов и выводит их на экран. Вывод сделать отдельным методом.

Console.Write("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i]= new Random().Next(0,100);
}
PrintArray(numbers);

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i=0;i<array.Length;i++)
    {Console.Write($"{numbers[i]} ");}
    Console.WriteLine("]");
}

