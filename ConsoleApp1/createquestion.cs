using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class createquestion
    {
        public static void creatingquestion(int a)
        {
            string qname;
            bool donewithquestion = false;
            while (donewithquestion == false)
            {

                Console.WriteLine("Give Your Question Bank Name");
                qname = Console.ReadLine();
                string aa = qname + ".txt";
                qname = aa;
                Console.WriteLine("How Many Question Do you want in this question bank");
                int count = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Enter Your question: ");
                    string question = Console.ReadLine();
                    File.AppendAllText(qname, question + "\n");
                    Console.WriteLine("Enter Your question's Answer: ");
                    string answer = Console.ReadLine();
                    string answersheet = "Answer" + qname;
                    File.AppendAllText(answersheet, answer + "\n");
                }
                Console.WriteLine("Press 1 if you are done Press 2 if you want to Enter another question Bank: ");
                int donewithbank = Convert.ToInt32(Console.ReadLine());
                if (donewithbank == 1)
                {
                    donewithquestion = true;
                }
                else { donewithquestion = false; }
            }
            
        }

    }
}
