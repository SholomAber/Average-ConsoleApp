using System;

class ClassAverage
{
    static void Main()
    {
        int total = 0;
        int studentCounter = 1;
        int studentTotal = 0;

        Console.Write("Please enter the amount of students in your class: ");
        studentTotal = int.Parse(Console.ReadLine());

        while (studentCounter <= studentTotal)
        {
            Console.Write($"Please enter the grade for student {studentCounter}: ");
            total += int.Parse(Console.ReadLine());
            studentCounter++;
        }

        Console.WriteLine($"The class total is {total}. The class average is {(double) total /studentTotal}.");

        Console.ReadKey();
    }
}