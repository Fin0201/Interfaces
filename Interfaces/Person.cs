using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal abstract class Person
    {
        public string Fname { get; set; }
        public string Sname { get; set; }
        protected Person(string fname, string sname)
        {
            Fname = fname;
            Sname = sname;
        }
    }
}
