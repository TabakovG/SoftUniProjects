﻿using System;

namespace GRADES
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine(getGrade(grade));

        }
        static string getGrade(double grade) 
        {
            string result = string.Empty;
            if (grade >= 2 && grade < 3)
            {
                result = "Fail";
            }
            else if (grade >= 3 && grade < 3.5)
            {
                result = "Poor";
            }
            else if (grade >= 3.5 && grade < 4.5)
            {
                result = "Good";
            }
            else if (grade >= 4.5 && grade < 5.5)
            {
                result = "Very good";
            }
            else if (grade >= 5.5 && grade <= 6)
            {
                result = "Excellent";
            }
            return result;
        }
    }
}
