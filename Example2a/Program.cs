//С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
//Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
//Тарорико Мария
using System;
   class Example
   {
        static void Main(string[] args)
        {
            int i, sum = 0;
            string input;
            do {
                Console.Write("Введите число: ");
                input= Console.ReadLine();
                int.TryParse(input, out i);
                if (i>0 && i % 2 == 1)  
                        sum = sum + i;
            }
             while (i != 0 );
             Console.WriteLine($"Сумма равна = {sum}");
    }
   }
   