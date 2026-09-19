

namespace Exam_System
{
    internal class Subject
    {
        int id;
        string name;
        Exam Exam;


        public Subject(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

       public void CreateExam(Exam exam) 
        {
            this.Exam = exam;
            exam.ShowExam();
        }
    }
}
