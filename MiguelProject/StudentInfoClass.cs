using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MiguelProject.StudentInfoClass;

namespace MiguelProject
{
    class StudentInfoClass
    {
        public delegate int DelegateNumber();
        public delegate string DelegateText();

        public static string FirstName = "";
        public static string LastName = "";
        public static string MiddleName = "";
        public static string Address = "";
        public static string Program = "";
        public static long Age = 0;
        public static long ContactNumber = 0;
        public static long StudentNumber = 0;

        public static string GetFirstName(string firstName)
        {
            return firstName;
        }
        public static string GetLastName(string lastName)
        {
            return lastName;
        }

        public static string GetMiddleName(string middleName)
        {
            return middleName;
        }

        public static string GetAddress(string address)
        {
            return address;
        }

        public static string GetProgram(string program)
        {
            return program;
        }

        public static long GetAge(long age)
        {
            return age;
        }

        public static long GetContactNumber(long contactNumber)
        {
            return contactNumber;
        }

        public static long GetStudentNumber(long studentNumber)
        {
            return studentNumber;
        }
    }
}
