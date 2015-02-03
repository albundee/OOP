using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Teacher : People 
    {
        private List<Disciplines> disciplines;
        public Teacher(string name,List<Disciplines> disciplines,string details):base(name,details)
        {
            this.Disciplines = disciplines;
        }
        public List<Disciplines> Disciplines{ 
            get
            {
                return this.disciplines;
            }
            set
            {
                this.disciplines = value;
            }
        }       
    }
}
