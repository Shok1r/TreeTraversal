using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeTraversal
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            HideCaret(textBox1.Handle);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            HideCaret(textBox1.Handle);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);
    }
}
