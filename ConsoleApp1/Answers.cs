using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Answers
    {
        public static void result(string studentAns,string original)
        {
            studentAns = studentAns + original + ".txt";
            string answersheet = "Answer" + original+".txt";
            try
            {

                string[] studentanswer = File.ReadAllLines(studentAns);
                string[] originalans = File.ReadAllLines(answersheet);

                int originalanswerlength = originalans.Length;
                double totalscorepossible = originalanswerlength*1;
                double Score = 0;
                double noscore = 0;
                for (int i = 0; i < originalanswerlength; i++)
                {
                    if (studentanswer[i].ToLower().Equals(originalans[i].ToLower()))
                    {
                        Score ++;
                    }
                    else
                    {
                        noscore++;
                    }
                }

                string scoreed = $"Scored {Math.Round(Score, 2)} in Test. Which is {Math.Round(Score / totalscorepossible, 2)*100}% of the Test";
                File.Delete("Score.txt");
                File.AppendAllText("Score.txt", scoreed);
                Console.WriteLine($"You scored {Math.Round(Score,2)} in this Test. Which is {Math.Round(Score/totalscorepossible,2)*100}% of the Test");

            }
            catch
            {
                Console.WriteLine("Sorry We were not able to process the test result now. We will get back to you ASAP. Thank You");
            }
        }
    }
}

