
namespace Exam_System
{
    internal class PricticalExam
    {
        Question[] questions;

        public PricticalExam(Question[] questions)
        {
            this.questions = questions;
        }


        public void DisplayRightAnswers()
        {
            Console.WriteLine("Right Answers for Practical Exam:");
            foreach (var question in questions)
            {
                Console.WriteLine($"Right Answer: {question.RightAnswer.Text}");
                Console.WriteLine();
            }
        }



    }
}
