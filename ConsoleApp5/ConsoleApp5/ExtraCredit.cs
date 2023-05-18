using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class ExtraCredit
    {
        public string Student;
        public int ExtraCreditNumber = 1;
        public double Score = 0;
        public static List<ExtraCredit> AllEC { get; } = new List<ExtraCredit>();


        public ExtraCredit(string student, int extraCreditNumber, double score)
        {
            Student = student;
            ExtraCreditNumber = extraCreditNumber;
            Score = score;
            AllEC.Add(this);
            

        }

    }
}
