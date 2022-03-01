using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Customer : IPerson
    {
        public string Fname { get; set; }
        public string Sname { get; set; }

        public Customer(string fname, string sname)
        {
            Fname = fname;
            Sname = sname;
        }
    }
}