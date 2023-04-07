using SealedProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor_MyExtension
{
    public static class MyExtension
    {
        public static int a;
        public static void Print(this DateTime dataTime)
        {
            Console.WriteLine(dataTime);
        }
        public static bool IsDayOfWeek(this DateTime dataTime, DayOfWeek dayOfWeek)
        {
            return dataTime.DayOfWeek == dayOfWeek;
            
        }
        public static string GetName(this Student student)
        {
            return student.FirstName + " " + student.LastName;
        }
    }
}
