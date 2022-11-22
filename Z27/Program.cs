//Задача 27: Напишите программу, которая принимает на 
//вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int x=Convert.ToInt32(Console.ReadLine());
string a = Convert.ToString(x);
int sum=0;

for (int i = 0; i < a.Length; i++)
{
sum+=int.Parse(Convert.ToString(a[i]));
}
Console.WriteLine(sum +" "); 





