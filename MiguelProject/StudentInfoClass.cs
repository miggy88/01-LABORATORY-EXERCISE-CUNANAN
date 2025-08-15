using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiguelProject
{
    class StudentInfoClass
    {
        public delegate int DelegateNumber(long number);
        public delegate void DelegateText(String txt);


        public static string FirstName = "";
        public static string LastName = "";
        public static string MiddleName = "";
        public static string Address = "";
        public static string Program = "";
        public static long Age = 0;
        public static long ContactNumber = 0;
        public static long  StudentNumber = 0;

        public static string GetFirstName(string FirstName)
        {
            return FirstName;
        }
        public static string GetLastName(string LastName)
        {
            return LastName;
        }

        public static string GetMiddleName(string MiddleName)
        {
            return MiddleName;
        }

        public static string GetAddress(string Address)
        {
            return Address;
        }

        public static string GetProgram(string Program)
        {
            return Program;
        }

        public static long GetAge(long Age)
        {
            return Age;
        }

        public static long GetContactNumber(long ContactNumber)
        {
            return ContactNumber;
        }   

        public static long GetStudentNumber(long StudentNumber)
        {
            return StudentNumber;
        }



    }
}
