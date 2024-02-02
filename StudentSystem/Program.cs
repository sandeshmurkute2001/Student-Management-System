using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students[] Stud = new Students[10];
            Students S = new Students();
            S.Welcome();
            while (true)
                {
                    S.DisplayMenu();
                    Console.Write(" Enter Your Coice  :");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            S.Addstudent(Stud);
                            break;
                        case 2:
                            S.Displaybyrollno(Stud);
                            break;
                        case 3:
                        S.Viewallstudent(Stud);
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                    }

                }
            
        }
    }
}
