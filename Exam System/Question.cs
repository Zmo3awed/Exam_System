using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_System
{
    internal class Question
    {
        QuestionType type;
        string body;
        double mark;
        Answer[] answers;
        Answer rightAnswer;
        public Question(int type,string body, double mark, Answer[] answers, Answer rightAnswer)
        {
            this.Body = body;
            this.Mark = mark;
            this.Answers = answers;
            this.RightAnswer = rightAnswer;
        }
        public String Body { get; set; }
        public double Mark { get; set; }
        public Answer[] Answers { get; set; }
        public Answer RightAnswer { get; set; }

        public void DisplayQuestion()
        {
            if(type == QuestionType.MultipleChoice)
            {
                Console.WriteLine("Question Type: Multiple Choice Question");

            }
            else if(type == QuestionType.TrueFalse)
            {
                Console.WriteLine("Question Type: True/False Question Chouse T/F");
                Console.WriteLine($"Question: {Body}");
                Console.WriteLine($"Mark: {Mark}");
                return;
            }
            Console.WriteLine($"Question: {Body}");
            Console.WriteLine($"Mark: {Mark}");
            Console.WriteLine("Answers:");
            for(int i=0; i<Answers.Length; i++)
            {
                Console.WriteLine($"{Answers[i].ID}- {Answers[i].Text}");
            }
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
