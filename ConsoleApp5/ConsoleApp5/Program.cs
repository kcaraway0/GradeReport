using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp5
{
     class Program
    {
        static void Main(string[] args)
        {

            Test TS1 = new Test("Sophia", 1, 90);
            Test TS2 = new Test("Sophia", 2, 86);
            Test TS3 = new Test("Sophia", 3, 87);
            Test TS4 = new Test("Sophia", 4, 98);
            Test TS5 = new Test("Sophia", 5, 100);

            Test TA1 = new Test("Andrew", 1, 92);
            Test TA2 = new Test("Andrew", 2, 89);
            Test TA3 = new Test("Andrew", 3, 81);
            Test TA4 = new Test("Andrew", 4, 96);
            Test TA5 = new Test("Andrew", 5, 90);

            Test TE1 = new Test("Emma", 1, 90);
            Test TE2 = new Test("Emma", 2, 85);
            Test TE3 = new Test("Emma", 3, 87);
            Test TE4 = new Test("Emma", 4, 98);
            Test TE5 = new Test("Emma", 5, 68);

            Test TL1 = new Test("Logan", 1, 90);
            Test TL2 = new Test("Logan", 2, 95);
            Test TL3 = new Test("Logan", 3, 87);
            Test TL4 = new Test("Logan", 4, 88);
            Test TL5 = new Test("Logan", 5, 96);


            ExtraCredit ECS1 = new ExtraCredit("Sophia", 1, 94);
            ExtraCredit ECS2 = new ExtraCredit("Sophia", 2, 90);

            ExtraCredit ECA1 = new ExtraCredit("Andrew", 1, 89);

            ExtraCredit ECE1 = new ExtraCredit("Emma", 1, 89);
            ExtraCredit ECE2 = new ExtraCredit("Emma", 1, 89);
            ExtraCredit ECE3 = new ExtraCredit("Emma", 1, 89);

            ExtraCredit ECL1 = new ExtraCredit("Logan", 1, 96);


            Student s1 = new Student("Sophia");
            Student s2 = new Student("Andrew");
            Student s3 = new Student("Emma");
            Student s4 = new Student("Logan");

         

            Console.WriteLine("Student     Grade/n");
           
            foreach (Student s in Student.Students)
            {
                s.getNumberGrade();
                s.getLetterGrade();
                Console.WriteLine($"{s.Name.PadRight(10)}   {s.NumberGrade}     {s.LetterGrade}");
            }
            Console.ReadKey();

        }
    }
}
