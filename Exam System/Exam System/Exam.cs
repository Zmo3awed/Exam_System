using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_System
{
    internal class Exam
    {
      
        protected int numOfQuestion;
        protected TimeSpan time;
        protected Question[] questions;
        public TimeSpan Time { get; set; }
        public int NumOfQuestion { get; set; }
        public Question[] Questions{ get; set; }

        public Exam(Question[] questions,int numOfQuestion, TimeSpan time)
        {
            this.NumOfQuestion = numOfQuestion;
            this.Time = time;
            this.questions = questions;
        }

        public virtual void ShowExam()
        {
            Console.WriteLine($"Exam Created with {numOfQuestion} questions and time limit of {time.TotalMinutes} minutes.");
     
        }

        public void DisplayRightAnswers()
        {
            Console.WriteLine("Right Answers for Exam:");
            foreach (var question in questions)
            {
                Console.WriteLine($"Question {question.Body}");
                Console.WriteLine($"Right Answer: {question.RightAnswer.Text}");
                Console.WriteLine();
            }
        }
        public virtual double CalculateTotalMarks() { return 0; }
    
    }
}
