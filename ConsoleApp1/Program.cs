using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool close = false;
            while (close == false)
            {
                bool answer = false;
                Console.WriteLine("                    Welcome to Adhikari Testing Center                          ");
                Console.WriteLine("<*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*>");
                Console.WriteLine("Press \"S\" if your are Student and Press \"T\" if you are Teacher");
                while (answer == false)
                {
                    string ans = Console.ReadLine();
                    if (ans == "S" || ans == "s")
                    {
                        student.studentpart(ans);
                        answer = true;
                    }
                    else if (ans == "T" || ans == "t")
                    {
                        teacher.teacherpart(ans);
                        answer = true;
                    }
                    else
                    {
                        answer = false;
                        Console.WriteLine("Please Press 1 if your are Student and Press 2 if you are Teacher");
                    }

                }
                Console.WriteLine("Press Y if you want to Continue Using Aplication OR <><>Press Any Key to close<><>");
                string closee = Console.ReadLine();
                if (closee == "Y"||closee=="y") { Console.Clear(); close = false; } else { close = true; }
            }
           
        }
    }
}
