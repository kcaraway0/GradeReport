using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Test
    {
        public string Student;
        public int TestNumber;
        public double Score = 0;
        public static List<Test> AllTests { get; } = new List<Test>();


        public Test(string student, int testNumber, int score)
        {
            Student = student;
            TestNumber = testNumber;
            Score = score;
            AllTests.Add(this); 
            
            testNumber++;   
    }

        

    }
}
