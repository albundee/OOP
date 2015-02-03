using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Disciplines:School 
    {
        private string name;
        private int numberoflectures;
        public Disciplines(string name,int numberoflectures,List<Student> students,string details):base (details)
        {
            this.Name = name;
            this.Numberoflectures = numberoflectures;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Numberoflectures
        {
            get
            {
                return this.numberoflectures;
            }
            set
            {
                this.numberoflectures = value;
            }
        }
    }
}

