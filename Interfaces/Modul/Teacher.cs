using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Modul
{
    class Teacher : Student
    {
        public DateTime DateOfBirth { get; set; }
        public string FIO { get; set; }
        public Gender Gender { get; set; }
        public int PersonID { get; set; }
        public int Age()
        {
            return (DateTime.Now.Year - DateOfBirth.Year);
        }

    }
}
