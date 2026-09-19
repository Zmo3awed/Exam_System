using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_System
{
    internal abstract class Question
    {
        string header;
        string body;
        double mark;
        Answer[] answers;
        Answer rightAnswer;
        public Question(string header,string body, double mark, Answer[] answers, Answer rightAnswer)
        {
            this.Body = body;
            this.Mark = mark;
            this.Answers = answers;
            this.RightAnswer = rightAnswer;
            this.header = header;

        }
        public String Body { get; set; }
        public double Mark { get; set; }
        public Answer[] Answers { get; set; }
        public Answer RightAnswer { get; set; }

        public virtual void DisplayQuestion()
        {
            Console.WriteLine($"Question Type: {header}");
            Console.WriteLine($"Question: {Body}");
            Console.WriteLine($"Mark: {Mark}");
        }
        
           
        public double CheckAnswer(int answerId)
        {
            if(RightAnswer.ID == answerId)
            {
              return Mark;
            }

            return 0;
           
        }

    }
}
