using MiguelProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiguelProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //LastName
            StudentInfoClass.StudentNumber = Convert.ToInt64(studentNumbertxtbox.Text);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Button 


           
        }

        private void lastNametxtbox_TextChanged(object sender, EventArgs e)
        {
            //lastname

            StudentInfoClass.LastName = lastNametxtbox.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //FirstName

            StudentInfoClass.FirstName = firstNametxtbox.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //MiddleName
            StudentInfoClass.MiddleName = middleNametxtbox.Text;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Program   
            StudentInfoClass.Program = programtxtbox.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //Age 

            StudentInfoClass.Age = Convert.ToInt64(agetxtbox.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Address

            StudentInfoClass.Address = addresstxtbox.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //ContactNumber
            StudentInfoClass.ContactNumber = Convert.ToInt64(contactNotxtbox.Text);




        }
    }
}

