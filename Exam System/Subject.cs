

namespace Exam_System
{
    internal class Subject
    {
        int id;
        string name;
        Exam Exam;


        public Subject(int id, string name, Exam exam)
        {
            this.id = id;
            this.name = name;
            this.Exam = exam;
        }

        public void CreatePracticalExam()
        {
            Exam.Type = examType.Practical;
            Exam.CreateExam();
        }
        public void CreateFinalExam()
        {
            Exam.Type = examType.Final;
            Exam.CreateExam();
        }
    }
}
