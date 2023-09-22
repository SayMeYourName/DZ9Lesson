// Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5. -> "5, 4, 3, 2, 1"
// N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"



string NaturalToLow(int n, int count) 
{ 
    if (count > n-1) 
        return ""; 
    return NaturalToLow(n, ++count) + $"{count} "; 
} 

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
NaturalToLow(number, count);
System.Console.WriteLine(NaturalToLow(number, count));