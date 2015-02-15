

namespace School
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class Program
    {
            public static void Main()
            {
                School notes = new School("something");
                Console.WriteLine(notes);
                School nullnotes = new School("");
                Console.WriteLine(nullnotes);
                Student pesho = new Student("Pesho", 11, "studentdetails");
                Student misho = new Student("Misho", 15, null);
                List<Student> liststudents = new List<Student>()
                {
                    pesho, misho
                };
                Console.WriteLine(pesho.Name);
                Console.WriteLine(pesho.Classnumber);
                Console.WriteLine(pesho.details);
                Console.WriteLine(misho.Name);
                Disciplines math = new Disciplines("Mathematics", 15, liststudents, "mathnotes");
                Disciplines phisics = new Disciplines("Phisics", 10, liststudents, null);
                Console.WriteLine(math.Name);
                Console.WriteLine(math.Numberoflectures);
                Console.WriteLine(math.details);
                Console.WriteLine(phisics.Name);
                People people = new People("Ivan", "peopledetails");
                Console.WriteLine(people.Name);
                List<Disciplines> listdisciplines = new List<Disciplines>()
                {
                    math, phisics
                };
                Teacher ii = new Teacher("Ivan Ivanov", listdisciplines, "teacherdetails");
                Teacher dd = new Teacher("Dim Dimitrov", listdisciplines, null);
                List<Teacher> listteachers = new List<Teacher>()
                {
                    ii, dd
                };
                Console.WriteLine(ii.Name);
                Console.WriteLine(ii.Disciplines);
                Console.WriteLine(ii.details);
                Console.WriteLine(dd.Name);
                Class aclass = new Class("A", listteachers, liststudents, "classnotes");
                Console.WriteLine(aclass.Identifier);
                Console.WriteLine(listteachers);
                Console.WriteLine(liststudents);
                Console.WriteLine(aclass.details);
            }
        }
    }
