using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Modul
{
    public enum Gender
    {
        Man=1,Girl=2
    }
    public interface IPerson
    {
        string FIO { get; set; }
        int Age();
        DateTime DateOfBirth { get; set; }
        Gender Gender { get; set; }
        int PersonID { get; set; }

    }
}
