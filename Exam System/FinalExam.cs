using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_System
{
    internal class FinalExam
    {
        Question[] questions;



        public FinalExam(Question[] questions)
        {
            this.questions = questions;
        }
        
        


         public double CalculateTotalMarks()
        {
            double totalMarks = 0;
            foreach (var question in questions)
            {
                totalMarks += question.Mark;
            }
            return totalMarks;
        }

        public void DisplayRightAnswers()
        {
            Console.WriteLine("Right Answers for Final Exam:");
            foreach (var question in questions)
            {
                Console.WriteLine($"Question {question.Body}");
                Console.WriteLine($"Right Answer: {question.RightAnswer.Text}");
                Console.WriteLine();
            }
        }
       

    }
}
