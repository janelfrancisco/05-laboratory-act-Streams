using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Streams_Act
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studentNo = txtStudentNo.Text;
            string program = txtprogram.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string middleInitial = txtMiddleInitial.Text;
            string age = txtAge.Text;
            string birthday = txtBirthday.Text;
            string contactNo = txtContactNo.Text;
            string gender = txtGender.Text;

            string filename = studentNo + ".txt";
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string[] studentInfo =
            {
                "Student No.: " + studentNo,
                "Program: " + program,
                "Full Name: " + firstName + " " + middleInitial + " " + lastName,
                "Age: " + age,
                "Birthday: " + birthday,
                "Gender: " + gender,
                "Contact No.: " + contactNo
            };




        }
    }
}
