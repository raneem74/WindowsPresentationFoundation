using StudentList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace StudentList
{
    internal class student
    {
 
        
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int grade { get; set; }
        public string image { get; set; }

        public override string ToString()
        {
            return name.ToString();
        }
    }

    
}
