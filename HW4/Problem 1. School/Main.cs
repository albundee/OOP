using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class program
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
                    pesho,misho
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
                    math,phisics
                };
                Teacher II = new Teacher("Ivan Ivanov", listdisciplines, "teacherdetails");
                Teacher DD = new Teacher("Dim Dimitrov", listdisciplines, null);
                List<Teacher> listteachers = new List<Teacher>()
                {
                    II,DD
                };
                Console.WriteLine(II.Name);
                Console.WriteLine(II.Disciplines);
                Console.WriteLine(II.details);
                Console.WriteLine(DD.Name);
                Class aclass = new Class("A", listteachers, liststudents, "classnotes");
                Console.WriteLine(aclass.Identifier);
                Console.WriteLine(listteachers);
                Console.WriteLine(liststudents);
                Console.WriteLine(aclass.details);
            }
        }
    }
