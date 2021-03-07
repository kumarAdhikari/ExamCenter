using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class teacher
    {
        public static void teacherpart(string a)
        {
            bool finish = false;
            //string[] questionBank = new string[100];
            Console.WriteLine("Please Provide your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome {name}, What would you like to do Today: ");
            Console.WriteLine("Press 1 for Create Questions\nPress 2 for Read/Delete Question Bank\nPress 3 to Check Marks of Student: ");
            

            while (finish==false){
                int ans = Convert.ToInt32(Console.ReadLine());
                if (ans == 1)
                {
                    createquestion.creatingquestion(ans);
                    finish = true;
                }

                else if (ans == 2)
                {
                    Console.WriteLine("Enter the Name of the Question Bank: ");
                    string qbankname = Console.ReadLine();
                    qbankname = qbankname + ".txt";
                    string[] lines = File.ReadAllLines(qbankname);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }

                    Console.WriteLine("To Delete Entire bank Press D OR to Exit press Any Key");
                    string selection = (Console.ReadLine());

                    if (selection == "D"|| selection == "d")
                    {
                        Console.WriteLine("Enter the Name of the Question Bank: ");
                        qbankname = Console.ReadLine();
                        qbankname = qbankname + ".txt";
                        File.Delete(qbankname);
                        Console.WriteLine("File Deleted Successfully....");
                        finish = true;
                    }
                    finish = true;
                }


                else if (ans == 3)
                {
                    bool wrongInfo = false;
                    Console.WriteLine("Please Enter the following details to view Results:");
                    while (wrongInfo == false)
                    {
                        Console.WriteLine("Enter the student's First name: ");
                        string studentname = Console.ReadLine();
                        Console.WriteLine("Year of birth: ");
                        string dobyear = Console.ReadLine();
                        Console.WriteLine($"Records for {studentname}");
                        string scoresheet = studentname + dobyear + ".txt";

                        try
                        {
                            Console.WriteLine(File.ReadAllText(scoresheet));
                            wrongInfo = true;
                        }
                        catch
                        {
                            Console.WriteLine("Student Record Doesnot exist OR you entered wrong Information.\nPlease Press any key to Try Again OR press 'E' to Exit");
                            string wantToExit = Console.ReadLine();
                            if (wantToExit == "e" || wantToExit == "E")
                            {
                                wrongInfo = true;
                            }
                            else { wrongInfo = false; }
                        }
                    }
                    finish = true;
                }
                else
                    finish = false;
                }
            }
        }
    }

