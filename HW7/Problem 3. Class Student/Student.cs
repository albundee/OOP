namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        public Student()
        {
        }
         public Student(string FirstName,string LastName,int Age,int FacultyNumber,string Email,List<int> Marks,int GroupNumber):this()
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.FacultyNumber = FacultyNumber;
            this.Phone = Phone;
            this.Email = Email;
            this.Marks = Marks;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public int FacultyNumber { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }
        
        public int GroupNumber { get; set; }

    }
}
