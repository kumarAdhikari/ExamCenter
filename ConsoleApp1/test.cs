using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class test
    {
        public static void testtaking(string examname,string studentname)
        {
            studentname = studentname + examname + ".txt";
            examname = examname + ".txt";
            
            try {

                string[] lines = File.ReadAllLines(examname);
                int questionlenth = lines.Length;
                for (int i=0;i<questionlenth;i++)
                {

                    Console.WriteLine($"Question {i}, {lines[i]}");
                    string answer=Console.ReadLine();
                    File.AppendAllText(studentname, answer+"\n");
                }
                Console.WriteLine("You have Completed your Exam. Good Luck with Results.");
                
            }
            catch
            {
                Console.WriteLine("File Does Not Exist. Please Ask Your Teacher to provide Exect Name of Test.");
            }
            }
    }
}
