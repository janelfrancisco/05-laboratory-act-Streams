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
    public partial class FrmFileName : Form
    {
        public static string SetFileName;
        public FrmFileName()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            // 4-5.  Inside the event, click the Okay button. Set the value of the static string SetFileName by calling the
            // value of txtFileName, and concatenate it with ".txt".

            SetFileName = txtFileName.Text + ".txt";

            // Call the Close() method afterward
            this.Close();
        }
    }
}
