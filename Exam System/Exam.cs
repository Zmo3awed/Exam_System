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
        examType type;
        public examType Type { get; set; }
        public TimeSpan Time {
            get { return time; }

            set 
            {
                if (value.TotalMinutes > 180|| value.TotalMinutes<30)
                {
                    Console.WriteLine("Minutes Must be Between 30 and 180");
                }
                time = value;

            }
        }
        public Exam(int numOfQuestion, TimeSpan time)
        {
            this.numOfQuestion = numOfQuestion;
            this.Time = time;
        }

        public void CreateExam()
        {
            Console.WriteLine($"Exam Created with {numOfQuestion} questions and time limit of {time.TotalMinutes} minutes.");
            if(Type == examType.Final)
            {
                Console.WriteLine("This is a Final Exam.");

            }
            else if(Type == examType.Practical)
            {
                Console.WriteLine("This is a Practical Exam.");
            }
        }
    }
}
