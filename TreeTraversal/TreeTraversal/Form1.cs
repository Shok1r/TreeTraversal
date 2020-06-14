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
    public partial class Form1 : Form
    {

        //For graphics
        public Bitmap bmp;
        public Graphics graph;
        public Pen pen;
        public Font drawFont;

        public CTree Tree;
        public string str_Traversal = " ";

        public Form1()
        {
            InitializeComponent();

            bmp = new Bitmap(picture.Width, picture.Height);
            graph = Graphics.FromImage(bmp);
            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Blue, 3);
            drawFont = new Font("Arial Rounded MT", 16);
        }

        private void treeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void drow_Tree()
        {
            graph.Clear(Color.FromArgb(7, 0, 45));
            drow_Node(Tree.Root);
            picture.Image = bmp;
            picture.Invalidate();
        }

        private void drow_Node(CNode root)
        {
            if (root != null)
            {
                if(root.Left != null)
                    graph.DrawLine(pen, root.X, root.Y, root.Left.X, root.Left.Y);
                if (root.Left != null)
                    graph.DrawLine(pen, root.X, root.Y, root.Right.X, root.Right.Y);
                graph.DrawImage(Resource1.Rectangle, root.X - 25, root.Y - 25, 50, 50);
                graph.DrawString(root.Data.ToString(), drawFont, Brushes.Black, root.X - 12, root.Y - 10);
                drow_Node(root.Left);
                drow_Node(root.Right);
            }
        }

        private void generateRandomTree(object sender, EventArgs e)
        {
            Tree = new CTree(false, 5, picture.Width / 2);
            drow_Tree();
        }

        private void generateTree(object sender, EventArgs e)
        {
            var generateTreeForm = new GenerateForm();

            if(generateTreeForm.ShowDialog() == DialogResult.OK)
                if (generateTreeForm.levels + 1 != 0)
                {
                    Tree = new CTree(true, generateTreeForm.levels + 1, picture.Width / 2);
                    drow_Tree();
                }

        }

        private void Prefix_Click(object sender, EventArgs e)
        {
            if (Tree != null)
            {

                if (str_Traversal != " ")
                    str_Traversal = str_Traversal.Remove(0, str_Traversal.Length);
                Prefix(Tree.Root);
                textBox1.Text = str_Traversal;

            }
        }
        private void Infix_Click(object sender, EventArgs e)
        {
            if (Tree != null)
            {
                if (str_Traversal != " ")
                    str_Traversal = str_Traversal.Remove(0, str_Traversal.Length);
                Infix(Tree.Root);
                textBox1.Text = str_Traversal;
            }
        }
        private void Postfix_Click(object sender, EventArgs e)
        {
            if (Tree != null)
            {
                if (str_Traversal != " ")
                    str_Traversal = str_Traversal.Remove(0, str_Traversal.Length);
                Postfix(Tree.Root);
                textBox1.Text = str_Traversal;

            }
        }

        private void Infix(CNode root)
        {
            if (root != null)
            {
                Infix(root.Left);
                str_Traversal += root.Data.ToString();
                Infix(root.Right);
            }
        }
        private void Postfix(CNode root)
        {
            if (root != null)
            {
                Postfix(root.Left);
                Postfix(root.Right);
                str_Traversal += root.Data.ToString();

            }
        }
        private void Prefix(CNode root)
        {
            if (root != null)
            {
                str_Traversal += root.Data.ToString();
                Prefix(root.Left);
                Prefix(root.Right);
            }
        }
    }
}
