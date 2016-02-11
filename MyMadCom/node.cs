using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMadCom
{
    class node
    {
        public node right { get; set; }
        public node left { get; set; }
        public QA value { get; set; }
        public node(QA element)
        {
            this.value = element;
            this.right = null;
            this.left = null;
        }
    }
}
