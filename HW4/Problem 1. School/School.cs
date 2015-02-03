using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class School
    {
        internal string details = null;
        public School()
        {
        }
        public School(string details)
        {
            this.Details = details;
        }
        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                this.details = value;
            }
        }
        public override string ToString()
        {
            return string.Format(details);
        }
    }
}

