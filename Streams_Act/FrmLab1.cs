using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Streams_Act
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // 3.In FrmLab1, double click the Create button and write the following syntax that are needed
            // Declare an instance FrmFileName and call ShowDialog() method.
            // Declare a string variable named getInput and get the value of the TextBox named txtInput

            FrmFileName frmFileName = new FrmFileName();
            frmFileName.ShowDialog();

            string getInput = txtInput.Text;

            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);

                MessageBox.Show("File Created!" + docPath);
            }



        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
