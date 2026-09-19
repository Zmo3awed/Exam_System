using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_System
{
    internal class FinalExam : Exam
    {
        Question[] questions;



        

        public FinalExam(Question[] questions, int numOfQuestion, TimeSpan time) : base(questions, numOfQuestion, time)
        {
            this.questions = questions;
        }

        public override void ShowExam()
        {
            base.ShowExam();
            Console.WriteLine("Final Exam Created.");

        }

        public override double CalculateTotalMarks()
        {
            double totalMarks = 0;
            foreach (var question in questions)
            {
                totalMarks += question.Mark;
            }
            return totalMarks;
        }


    }
}
