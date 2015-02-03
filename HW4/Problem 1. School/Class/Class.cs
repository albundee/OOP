using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Class:School
    {
        private string identifier;
        private List<Teacher> teachers;
        private List<Student> students;
        public Class(string identifier)
        {
            this.Identifier = identifier;
        }
        public Class(string identifier,List<Teacher> teachers,List<Student> students,string details):base (details)
        {
            this.Identifier = identifier;
            this.Teachers = teachers;
            this.Students = students;
        }
        public string Identifier
        {
            get
            {
                return this.identifier;
            }
            set
            {
                this.identifier = value;
            }
        }
        public List<Teacher> Teachers 
        {  get
            {
                return this.teachers;
            }
            set
            {
                this.teachers = value;
            }
        }
         public List<Student> Students 
        {  get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }
    }
}
