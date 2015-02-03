using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student:People 
    {
        private int classnumber;
        public Student (string name, int classnumber,string details):base (name,details)
        {
            this.Classnumber = classnumber;
        }
        public int Classnumber
        { 
            get
            {
                return this.classnumber;
            }
            set
            {
                this.classnumber = value;
            }
        }
    }
}
