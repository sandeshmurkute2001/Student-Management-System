using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    internal class Students
    {
        public string Name { get; set; }
        public int Rollno { get; set; }
        public float Subject1 { get; set; }
        public float Subject2 { get; set; }
        public float Subject3 { get; set; }
        public int opt { get; set; }
        public string Subject4 { get; set; }
        public string Subject5 { get; set; }
        private static int sizeofstd;

        public void Addstudent(Students[] S )
        {
            Console.WriteLine("How Many Students ?");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int count=sizeofstd; count<sizeofstd+size; count++)
            {
                S[count] = new Students();

                Console.Write("_____________________________\n");
               
                Console.Write("Enter Name: ");
                S[count].Name = Convert.ToString(Console.ReadLine());
                Console.Write("Enter Student Roll No: ");
                S[count].Rollno = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Physics Marks: ");
                S[count].Subject1 = Convert.ToSingle(Console.ReadLine());
                Console.Write("Enter Chemestry Marks: ");
                S[count].Subject2 = Convert.ToSingle(Console.ReadLine());
                Console.Write("Enter Maths Marks: ");
                S[count].Subject3 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("\nSelect Optional sub: ");
                Console.WriteLine("1:Biology");
                Console.WriteLine("2:Social Science: ");
                S[count].opt = Convert.ToInt32(Console.ReadLine());
                if (S[count].opt == 1)
                {
                    Console.Write("Enter Biology Grade:");
                    S[count].Subject4 = Console.ReadLine();
                }
                if (S[count].opt == 2)
                {
                    Console.Write("Enter Social Science Grade:");
                    S[count].Subject5 = Console.ReadLine();
                }

                Console.WriteLine("_____________________________\n");
            }
            sizeofstd += size;
        }
        public void Displaybyrollno(Students[] S)
        {
            DateTime dt;
            Console.WriteLine("Enter roll No: ");
            int roll=Convert.ToInt32(Console.ReadLine());
            int index = 0;
            for(int count = 0; count < sizeofstd; count++)
            {
                if (S[count].Rollno == roll)
                {
                    index = count;
                    break;
                }
            }
            if (index >= 0)
            {
                Console.WriteLine("_________________________");
                Console.Write($" \n Student Name: {S[index].Name}");
                Console.Write($" \n {S[index].Name} Roll No: {S[index].Rollno}");
                Console.Write($" \n {S[index].Name} Physics Marks: {S[index].Subject1}");
                Console.Write($" \n {S[index].Name} Chemestry Marks: {S[index].Subject2}");
                Console.Write($" \n {S[index].Name} Maths Marks: {S[index].Subject3}");
                if (S[index].opt == 1)
                {
                    Console.Write($" \n Student Biology Grade: {S[index].Subject4}\n");
                }
                else
                {
                    Console.Write($" \n Student Social Science Grade: {S[index].Subject5}\n");
                }
                Console.WriteLine("_________________________\n");

            }

        }
        public void Viewallstudent(Students[] S)
        {
            for(int count=0;count<sizeofstd; count++) 
            { 
                Console.WriteLine("_________________________");
                Console.WriteLine($"Students Name: " + S[count].Name);
                Console.WriteLine($"{S[count].Name} Roll No: " + S[count].Rollno);
                Console.WriteLine($"{S[count].Name} Physics Marks: " + S[count].Subject1);
                Console.WriteLine($"{S[count].Name} Chemestry Marks: " + S[count].Subject1);
                Console.WriteLine($"{S[count].Name} Maths Marks: " + S[count].Subject1);
                if (S[count].opt == 1)
                {
                    Console.WriteLine($" \n Student Biology Grade: {S[count].Subject4}\n");
                }
                else
                {
                    Console.WriteLine($" \n Student Social Science Grade: {S[count].Subject5}\n");
                }
                Console.WriteLine("_________________________");
            }
        }


        public void Welcome()
        {
            Console.WriteLine("\n --------Welcome-------\n ");
        }
        public void DisplayMenu()
        {
            
            Console.WriteLine("Tap 1. Add Students");
            Console.WriteLine("Tap 2. View Students by 'ROLL NO'");
            Console.WriteLine("Tap 3. View All Students Details");
            Console.WriteLine("Tap 4. Exit from application  \n\n");
        }
    }
}