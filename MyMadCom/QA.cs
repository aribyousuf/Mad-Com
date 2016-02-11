using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMadCom
{
    public class QA
    {
        public QA(string Ques, string Ans)
        {
            Question = Ques;
            Answer = Ans;
        }
        private string Question;
        public string Question1
        {
            get { return Question; }
            set { Question = value; }
        }
        private string Answer;
        public string Answer1
        {
            get { return Answer; }
            set { Answer = value; }
        }
    }
}
