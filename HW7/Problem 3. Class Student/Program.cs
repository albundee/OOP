namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student{ FirstName = "Ivan", LastName = "Ivanov", Age = 24, FacultyNumber = 111114, Phone = "11234567", Email = "iivanov@mail.bg",Marks = new List<int>(){2,2,3,4,4,5}, GroupNumber = 222 },
                new Student{FirstName="Pesho",LastName="Peshev",Age=35,FacultyNumber=222222,Phone="+359 21567890",Email="ppeshev@abv.bg",Marks = new List<int>(){6,6,5,3,4},GroupNumber=2},
                new Student{FirstName="George",LastName="Georgiev",Age=45,FacultyNumber=333314,Phone="02/8456789887",Email="ggerogiev@yahoo.com.bg",Marks = new List<int>(){5,3,3,3,4,2,4,6},GroupNumber=2},
               
            };
            var StudentsbyGroup =
                from st in students
                orderby st.FirstName
                where st.GroupNumber == 2
                select st.FirstName;
            Console.WriteLine("students by FirstName:");

            foreach (var items in StudentsbyGroup)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine();
            Console.WriteLine("Students by First and Last Name: ");
            var StudentsbyFirstandLastName = students.OrderBy(st => st.FirstName).ThenBy(st => st.LastName);
            foreach (var items in StudentsbyFirstandLastName)
            {
                Console.WriteLine(items.FirstName + " " + items.LastName);
            }
            Console.WriteLine();
            Console.WriteLine("Students by Age: ");
            var StudentsbyAge =
                from st in students
                where st.Age > 18 && st.Age <= 24
                select st;
            foreach (var items in StudentsbyAge)
            {
                Console.WriteLine(items.FirstName + " " + items.LastName + " " + items.Age);
            }
            Console.WriteLine();
            Console.WriteLine("Sort Students: ");
            var SortStudents = students.OrderByDescending(st => st.FirstName).ThenBy(st => st.LastName);
            foreach (var items in SortStudents)
            {
                Console.WriteLine(items.FirstName + " " + items.LastName);
            }

            Console.WriteLine();
            Console.WriteLine("Students by Email Domain: ");
            var StudentsEmailDomain = students.FindAll(st => st.Email.Contains("@abv.bg"));
            foreach (var items in StudentsEmailDomain)
            {
                Console.WriteLine(items.FirstName + " " + items.LastName + " " + items.Email);
            }
            Console.WriteLine();
            Console.WriteLine("Students by Phone: ");
            var StudentsbyPhone = students.FindAll(st => st.Phone.StartsWith("02") || st.Phone.StartsWith("+3592") || st.Phone.StartsWith("+359 2"));

            foreach (var items in StudentsbyPhone)
            {
                Console.WriteLine(items.FirstName + " " + items.LastName + " " + items.Phone);
            }
            Console.WriteLine();
            Console.WriteLine("Excellent Students: ");
            var ExcellentStudents = students.FindAll(st => st.Marks.Contains(6));
            int x = 0;
            foreach (var items in ExcellentStudents)
            {
                Console.WriteLine(items.FirstName + " " + items.LastName + " ");
                foreach (var m in ExcellentStudents[x].Marks)
                {
                    Console.Write(m + " ");
                }
                x++;
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Weak Students: ");
            var WeakStudents = students.FindAll(st => st.Marks.Count(std => std.Equals(2)) == 2);
            int y = 0;
            foreach (var items in WeakStudents)
            {
                Console.WriteLine(items.FirstName + " " + items.LastName + " ");
                Printextention.PrintCollection(WeakStudents[y].Marks);
                y++;
                Console.WriteLine();
            }
            Console.WriteLine();
            int yeartocheck = 14;
            var StudentsEnrolledin2014 = students.FindAll(std => (std.FacultyNumber % 100) == yeartocheck);
            Console.WriteLine("List of students marked as enrolled in 2014: ");
            int z = 0;
            foreach (var items in StudentsEnrolledin2014)
            {
                Console.WriteLine("Student name: {0} {1}", items.FirstName, items.LastName);
                foreach (var m in StudentsEnrolledin2014[z].Marks)
                {
                    Console.Write(m + " ");
                }
                z++;
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}