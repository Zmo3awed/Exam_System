using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_System
{
    internal class Answer
    {
        int id;
        string text;

        public Answer (int id, string text)
        {
            this.ID = id;
            this.Text = text;
        }

        public int ID { get; set; }
        public string Text { get; set; }


    }
}
