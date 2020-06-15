using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeTraversal
{
   
    public partial class Exam_PassForm : Form
    {
        
        public Exam_PassForm(int Errors)
        {
            
            InitializeComponent();
            textBox1.Text = Errors.ToString();
        }

        private void Exam_Pass_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
