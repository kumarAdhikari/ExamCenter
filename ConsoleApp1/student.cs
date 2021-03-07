using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class student
    {
        public static void studentpart(string a)
        {
            Console.WriteLine("Enter Your Name: ");
            string studentname = Console.ReadLine();
            Console.WriteLine("Enter Your Year of Birth. (eg. 1996): ");
            string dob = Console.ReadLine();
            Console.WriteLine($"Hello {studentname}, What exam are you taking? Enter the Name of Exam: (Eg. ExamOne): ");
            string examname = Console.ReadLine();
            test.testtaking(examname,studentname);
            Console.WriteLine("Processing...........................");
            Answers.result(studentname,examname);
            string scoresheet = studentname + dob + ".txt";
            File.Create(scoresheet);
            try
            {
                File.Copy("Score.txt", scoresheet);
            }
            catch
            {
                File.Delete(scoresheet);
                File.Copy("Score.txt", scoresheet);
            }

        }
        public static double result(string a,string b)
        {
            double score = Math.Round(100.006,2);
            return score;
        }
    }
}
