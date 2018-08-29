using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ClassAverage
{
    static void Main()
    {
        int total = 0;
        int grades = 1;
        int studentCount = 0;

        Console.Write("Please enter the amount of students in your class: ");
        studentCount = int.Parse(Console.ReadLine());

        while (grades <= studentCount)
        {
            Console.Write($"Please enter the grade for student {grades}: ");
            total += int.Parse(Console.ReadLine());
            grades++;
        }

        Console.WriteLine($"The class total is {total}. The class average is {total/studentCount}.");

        Console.ReadKey();
    }
}