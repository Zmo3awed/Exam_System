using System.Diagnostics;
namespace Exam_System
{
    internal class Program
    {
        static string Check_string(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("Your string should not be null or white space.");
                return Check_string(Console.ReadLine());
            }

            return s;
        }
        static double Check_double(string s)
        {
            if (!double.TryParse(s, out double result))
            {
                Console.WriteLine("Your input should be a number.");
                return Check_double(Console.ReadLine());
            }

            if (result <= 0)
            {
                Console.WriteLine("Your input should be a positive number.");
                return Check_double(Console.ReadLine());
            }

            return result;
        }

       
        static int Check_int(string s)
        {
            if (!int.TryParse(s, out int result) || result <= 0)
            {
                Console.WriteLine("Your input should be a positive integer.");
                return Check_int(Console.ReadLine());
            }

            return result;
        }
        public static void print<T>(T value)
        {
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            double totalMarks = 0;

            print("enter subject name");
            string subjectName = Check_string(Console.ReadLine());
            print("enter subject id");
            int subjectId = Check_int(Console.ReadLine());
            print("enter type of exam (1. for Prictical 2. for final)");
            int type = Check_int(Console.ReadLine());
            print("enter number of questions");
            int numOfQuestions = Check_int(Console.ReadLine());
            print("enter time of exam in minutes");
            int timeInMinutes = Check_int(Console.ReadLine());
            while (timeInMinutes < 30 || timeInMinutes > 180)
            {
                print("Time should be between 30 and 180 minutes. Please enter a valid time:");
                timeInMinutes = Check_int(Console.ReadLine());
            }
            Subject subject = new Subject(subjectId, subjectName);

            Question[] questions = new Question[numOfQuestions];
            for (int i = 0; i < numOfQuestions; i++)
            {
                print($"Enter question {i + 1} body:");
                string questionBody = Check_string(Console.ReadLine());
                print($"Enter question {i + 1} mark:");
                double questionMark = Check_double(Console.ReadLine());
                if (type == 2)
                {
                    print($"Enter question {i + 1} type (1. for multiple choice 2. for true/false):");
                    int Qtype = Check_int(Console.ReadLine());
                    if (Qtype == 1)
                    {
                        Answer[] answers = new Answer[4];
                        for (int j = 0; j < 4; j++)
                        {
                            print($"Enter answer {j + 1} body:");
                            string answerBody = Check_string(Console.ReadLine());
                            answers[j] = new Answer(j + 1, answerBody);
                        }
                        print($"Enter the index of the right answer for question {i + 1} (1-4):");
                        int rightAnswerId = Check_int(Console.ReadLine());
                        questions[i] = new MCQ("MCQ", questionBody, questionMark, answers, answers[rightAnswerId - 1]);
                    }
                    else if (Qtype == 2)
                    {
                        Answer[] answers = new Answer[2];
                        answers[0] = new Answer(1, "True");
                        answers[1] = new Answer(2, "False");
                        print($"Enter the index of the right answer for question {i + 1} (1-2):");
                        int rightAnswerId = Check_int(Console.ReadLine());
                        questions[i] = new TrueOrFalse("T/F", questionBody, questionMark, answers, answers[rightAnswerId-1]);
                    }
                }
                else
                {
                    Answer[] answers = new Answer[4];
                    for (int j = 0; j < 4; j++)
                    {
                        print($"Enter answer {j + 1} body:");
                        string answerBody = Check_string(Console.ReadLine());
                        answers[j] = new Answer(j + 1, answerBody);
                    }
                    print($"Enter the index of the right answer for question {i + 1} (1-4):");
                    int rightAnswerId = Check_int(Console.ReadLine());
                    questions[i] = new MCQ("MCQ", questionBody, questionMark, answers, answers[rightAnswerId - 1]);

                }

            }
            print("Do you want to start the exam? (y/n)");
            string startExam = Check_string(Console.ReadLine());
            if (startExam.ToLower() == "y"||startExam=="1")
            {
                Exam exam;
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                if (type == 2)
                {

                    exam = new FinalExam(questions, numOfQuestions, TimeSpan.FromMinutes(timeInMinutes));
                    subject.CreateExam(exam);
                    Console.WriteLine("--------------------");
                }
                else
                {
                    exam = new PricticalExam(questions, numOfQuestions, TimeSpan.FromMinutes(timeInMinutes));
                    subject.CreateExam(exam); 
                    Console.WriteLine("--------------------");

                }

                for (int i = 0; i < numOfQuestions; i++)
                {
                    questions[i].DisplayQuestion();
                    print("Enter your answer Id:");
                    int answerId = Check_int(Console.ReadLine());
                    totalMarks += questions[i].CheckAnswer(answerId);

                }
                if (type == 2)
                {
                  
                    exam.DisplayRightAnswers();
                    print($"Your total marks is: {totalMarks}/{exam.CalculateTotalMarks()}");
                }
                else
                {
                    exam.DisplayRightAnswers();
                }

                stopwatch.Stop();
                if (stopwatch.Elapsed.TotalMinutes > timeInMinutes)
                {
                    print("You have exceeded the time limit for the exam.");
                }
                Console.WriteLine($"You spend :{stopwatch.Elapsed}");
            }
            else if (startExam.ToLower() == "n"||startExam=="2")
            {
                print("Exam not started.");
            }
            else
            {
                print("Invalid input. Exam not started.");
            }
        }
              
        
    }
}
