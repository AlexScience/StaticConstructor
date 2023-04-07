using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedProperties
{
    public sealed class Student
    {
        public string FirstName { get; set; }//свойства
        public string LastName { get; set; }//свойства
    }
}
