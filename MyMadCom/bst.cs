using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace MyMadCom
{
    class bst
    {
        //public TextBox a;
        public node root { get; set; }
        public void add(QA e)
        {
            node n = new node(e);
            if (root == null)
            {
                root = n;
            }
            else
            {
                node temp = root;
                while (true)
                {
                    int x = e.Question1.CompareTo(root.value.Question1);

                    if (x == 1)
                    {
                        if (temp.right != null)
                        {
                            temp = temp.right;
                        }
                        else
                        {
                            temp.right = n;
                            break;
                        }
                    }
                    else
                    {
                        if (temp.left != null)
                        {
                            temp = temp.left;
                        }
                        else
                        {
                            temp.left = n;
                            break;
                        }
                    }
                }
            }
        }
        private void InOrder(node n, ref string Answer, string Question)
        {
            if (n != null)
            {

                InOrder(n.left, ref Answer, Question);

                if (Question == n.value.Question1)
                {
                    Answer = n.value.Answer1;
                }
                InOrder(n.right, ref Answer, Question);
            }
        }
        string _Ques;
        public void Print(ListBox lb, string Question)
        {
            if (lb.Items.Count > 2)
            {
                if (lb.Items[lb.Items.Count - 1].ToString() != "I cannot understand your Question, Please train me." && lb.Items[lb.Items.Count - 2].ToString() != "I cannot understand your Question, Please train me.")
                {
                    _Ques = Question;
                    string Answer = string.Empty;
                    InOrder(root, ref Answer, Question);
                    if (string.IsNullOrEmpty(Answer))
                    {
                        lb.Items.Add("Mad com : " + "I cannot understand your Question, Please train me.");
                    }
                    else
                    {
                        lb.Items.Add("Mad com : " + Answer);
                    }
                }
                else
                {
                    QA newInformation = new QA(_Ques, lb.Items[lb.Items.Count - 1].ToString());
                    add(newInformation);
                    lb.Items.Add("Mad com : " + "Thank you for Training");
                }
            }
            else
            {
                _Ques = Question;
                string Answer = string.Empty;
                InOrder(root, ref Answer, Question);
                if (string.IsNullOrEmpty(Answer))
                {
                    lb.Items.Add("Mad com : " + "I cannot understand your Question, Please train me.");
                }
                else
                {
                    lb.Items.Add("Mad com : " + Answer);
                }
            }
        }


    }
}
