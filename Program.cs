// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

 int FindSumNumbers(int num)
 {
     int sum = 0;
     for (int i = 1; num > 0; i++)
     {
         sum = sum + (num % 10);
         num = num / 10;
     }
     return sum;
 }
 System.Console.WriteLine("Input number -> ");
 int num = Convert.ToInt32(Console.ReadLine());
 System.Console.WriteLine($"Number {num} Sum of digits -> {FindSumNumbers(num)}");
