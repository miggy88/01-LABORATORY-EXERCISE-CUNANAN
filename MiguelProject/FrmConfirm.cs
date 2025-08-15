using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MiguelProject.StudentInfoClass;


namespace MiguelProject
{
    public delegate string DelegateText();
    public delegate long DelegateNumber();
    public partial class Form2: Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelAge, DelContactNumber, DelStudentNumber;

        private void Form2_Load(object sender, EventArgs e)
        {
            StudentNotxtbox.Text = DelStudentNumber().ToString();

            Fnametxtbox.Text = DelFirstName();

            lastNametxtbox.Text = DelLastName();

            middleNametxtbox.Text = DelMiddleName();

            addresstxtbox.Text = DelAddress();

            programtxtbox.Text = DelProgram();

            agetxtbox.Text = DelAge().ToString();

            contactNotxtbox.Text = DelContactNumber().ToString();
        }

        public Form2()
        {
            InitializeComponent();

            DelProgram = new DelegateText(() => StudentInfoClass.GetProgram(StudentInfoClass.Program));
            DelLastName = new DelegateText(() => StudentInfoClass.GetLastName(StudentInfoClass.LastName));
            DelFirstName = new DelegateText(() => StudentInfoClass.GetFirstName(StudentInfoClass.FirstName));
            DelMiddleName = new DelegateText(() => StudentInfoClass.GetMiddleName(StudentInfoClass.MiddleName));
            DelAddress = new DelegateText(() => StudentInfoClass.GetAddress(StudentInfoClass.Address));

            DelAge = new DelegateNumber(() => StudentInfoClass.GetAge(StudentInfoClass.Age));
            DelContactNumber = new DelegateNumber(() => StudentInfoClass.GetContactNumber(StudentInfoClass.ContactNumber));
            DelStudentNumber = new DelegateNumber(() => StudentInfoClass.GetStudentNumber(StudentInfoClass.StudentNumber));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
