using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_quiz
{
    internal class Question
    {
        public string Text { get; set; }
        public String [] option { get; set; }
        public int Corr_option { get; set; }

        public Question (string text ,  string[] options , int corr_option)
        {
            Text = text;
            Corr_option = corr_option;
            option = options;
        }
    }
}
