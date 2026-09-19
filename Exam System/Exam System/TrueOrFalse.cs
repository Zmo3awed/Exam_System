using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_System
{
    internal class TrueOrFalse : Question
    {
        public TrueOrFalse(string header, string body, double mark, Answer[] answers, Answer rightAnswer) : base(header, body, mark, answers, rightAnswer)
        {
        }

        public override void DisplayQuestion()
        {
            base.DisplayQuestion();
            Console.WriteLine("Answers:");
            Console.WriteLine("1. True");
            Console.WriteLine("2. False");
        }
    }
}
