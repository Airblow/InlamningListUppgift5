using System;
using System.Collections.Generic;

namespace InlamningListUppgift5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> monthlySalary = new List<float>();

            //user input
            bool userInputLoop = true;
            Console.WriteLine("Skriv in dina senaste månadslönder, avsluta inmatningen genom att ange '0'.");

            while (userInputLoop == true)
            {
                try
                {
                    int userInput = int.Parse(Console.ReadLine());

                    if (userInput == 0)
                    {
                        userInputLoop = false;
                        Console.Clear();
                    }
                    else
                    {
                        monthlySalary.Add(userInput);
                    }
                }
                catch
                {
                    Console.WriteLine("Något gick fel, försök igen");
                    Console.ReadLine();
                }

            }

            //average salary
            float totalSalary = 0;
            int listElements = monthlySalary.Count;
            for (int i = 0; i < listElements; i++)
            {
                totalSalary += monthlySalary[i];
            }
            float salaryAverage = totalSalary / listElements;

            Console.Clear();
            Console.WriteLine($"Din medellön är: {salaryAverage}");

            //median salary
            float medianSalary = 0;
            monthlySalary.Sort();
            int medianIndex = listElements / 2;
            if (listElements % 2 == 0)
            {
                medianSalary = (monthlySalary[medianIndex - 1] + monthlySalary[medianIndex]) / 2;
            }
            else
            {
                medianSalary = monthlySalary[medianIndex];
            }

            Console.WriteLine($"Din medianlön är: {medianSalary}");

            Console.ReadKey();
        }
    }

}