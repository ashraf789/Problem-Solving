using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {

            // problem 1:
            BaseBall();

            // problem 2:
            ValidParameter();

            Console.ReadKey();
        }

        static void BaseBall()
        {
            string[] Scores = { "5", "2", "C", "D", "+" };

            int result = BaseBallScore.GetScore(Scores);
            Console.WriteLine(result);
        }

        static void ValidParameter()
        {

            string Data1 = "()()[]";
            string Data2 = "[(){()}]";
            string Data3 = "[({}{}({}))]";
            string Data4 = "[(}{)]";

            Console.WriteLine(ValidInvalid.IsValid(Data1));
            Console.WriteLine(ValidInvalid.IsValid(Data2));
            Console.WriteLine(ValidInvalid.IsValid(Data3));
            Console.WriteLine(ValidInvalid.IsValid(Data4));
        }
    }
}
