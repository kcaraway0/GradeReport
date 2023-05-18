using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Student
    {
        public string Name { get; set; }
        public double NumberGrade
        {
            get { return getNumberGrade(); }
        }
        public string LetterGrade
        {
            get { return getLetterGrade(); }
        }
        private List<Test> MyTests { get; set; }
        private List<ExtraCredit> MyEC{ get; set; }
        public static List<Student> Students { get; } = new List<Student>();

        


    



        public Student(string name)
        {
            Name = name;
            MyTests = new List<Test>();
            MyEC = new List<ExtraCredit>();
            {
                foreach (Test t in Test.AllTests)
                {


                    if (t.Student == Name)
                    {
                        MyTests.Add(t);
                    }
                }
                foreach (ExtraCredit ec in ExtraCredit.AllEC)
                {
                    if (ec.Student == Name)
                    {
                        MyEC.Add(ec);
                    }
                }
            }
            Students.Add(this);
        }


        public double getNumberGrade()
        {
            double testScoreSum = 0;
            double extraCreditSum = 0;
            double grade;

            foreach (Test singleTest in MyTests)
            {
                testScoreSum += singleTest.Score;
            }
            foreach (ExtraCredit singleExtraCredit in MyEC)
            {
                extraCreditSum += (singleExtraCredit.Score *.1);   //Extra Credit is weighted as 10% of a single Test score
                
            }
            
                grade = (testScoreSum + extraCreditSum) / MyTests.Count;
           
            return grade;
        }

        public string getLetterGrade()
        {
            switch (NumberGrade)
            {
                case >= 97:
                    return "A+";
                case >= 93:
                    return "A";
                case >= 90:
                    return "A-";
                case >= 87:
                    return "B+";
                case >= 83:
                    return "B";
                case >= 80:
                    return "B-";
                case >= 77:
                    return "C+";
                case >= 73:
                    return "C";
                case >= 70:
                    return "C-";
                case >= 67:
                    return "D+";
                case >= 63:
                    return "D";
                case >= 60:
                    return "D-";
                    break;
                default:
                    return "F";

            }

        }
    }

}
