// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//  M = 1; N = 15 -> 120
//  M = 4; N = 8. -> 30
 
string PrintNumbers(int m, int n) 
{ 
   if (n < m) 
        return "";
   n= (n * (n + 1) )/ 2 - (m*(m-1)/2);
   return (PrintNumbers(n, m) + $"{n} ");
} 
 
System.Console.WriteLine("Введите нижнюю границу M"); 
int min = Convert.ToInt32(Console.ReadLine()); 
System.Console.WriteLine("Введите верхнюю границу N"); 
int max = Convert.ToInt32(Console.ReadLine()); 
System.Console.WriteLine(PrintNumbers(min, max));