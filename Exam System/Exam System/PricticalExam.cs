

namespace Exam_System
{
    internal class PricticalExam : Exam 
    {
        Question[] questions;

       

        public PricticalExam(Question[] questions,int numOfQuestion, TimeSpan time) : base(questions,numOfQuestion, time)
        {
            this.questions =questions;
        }

       public override void ShowExam()
        {
            base.ShowExam();
            Console.WriteLine("Practical Exam Created.");
        }
       


    }
}
