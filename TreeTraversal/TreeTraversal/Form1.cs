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
        public string str_Traversal = "";

        public string Exam_str_Traversal = "";
        public bool Exam = false;
        public int Char_count = 0;
        public int Error_count = 0;

        public Form1()
        {
            InitializeComponent();

            bmp = new Bitmap(picture.Width, picture.Height);
            graph = Graphics.FromImage(bmp);
            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Blue, 3);
            drawFont = new Font("Arial Rounded MT", 16);
            exitToolStripMenuItem.Enabled = false;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            if (Exam)
            {
                var location = e.Location;
                Check_Circle(Tree.Root, location.X, location.Y);
            }

        }

        private void Check_Circle(CNode Root, int X, int Y)
        {
            if (Root != null)
            {
                int dx = X - Root.X, dy = Y - Root.Y;
                if (Math.Sqrt(dx * dx + dy * dy) <= 25)
                {
                    Exam_str_Traversal += Root.Data.ToString();
                    if (str_Traversal[Char_count] == Root.Data)
                    {
                        Root.Selected = true;
                        Char_count++;
                        drow_Tree();
                        textBox1.Text = Exam_str_Traversal;
                        if (Exam_str_Traversal == str_Traversal)
                        {
                            var ExamPass = new Exam_PassForm(Error_count);
                            ExamPass.ShowDialog();
                            Exam_passed(Tree.Root);
                            Exam = false;
                            treeToolStripMenuItem.Enabled = true;
                            exitToolStripMenuItem.Enabled = false;
                            str_Traversal = "";
                            textBox1.Text = str_Traversal;
                            drow_Tree();

                        }
                    }
                    else
                    {
                        var Error = new ErrorForm();
                        Error.ShowDialog();
                        Exam_str_Traversal = Exam_str_Traversal.Remove(Exam_str_Traversal.Length - 1);
                        Error_count++;
                    }

                }
                else
                {
                    Check_Circle(Root.Left, X, Y);
                    Check_Circle(Root.Right, X, Y);
                }
            }
        }
        private void Exam_passed(CNode root)
        {
            if (root != null)
            {
                root.Selected = false;
                Exam_passed(root.Left);
                Exam_passed(root.Right);
            }
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
                if (root.Left != null)
                    graph.DrawLine(pen, root.X, root.Y, root.Left.X, root.Left.Y);
                if (root.Left != null)
                    graph.DrawLine(pen, root.X, root.Y, root.Right.X, root.Right.Y);
                if (root.Selected)
                    graph.DrawImage(Resource1.BlueCircle, root.X - 25, root.Y - 25, 50, 50);
                else
                    graph.DrawImage(Resource1.GreenCircle, root.X - 25, root.Y - 25, 50, 50);

                Size textSize = TextRenderer.MeasureText(root.Data.ToString(), drawFont); //Вычисление размера символа в пикселях
                graph.DrawString(root.Data.ToString(), drawFont, Brushes.Black, root.X - textSize.Width / 2 + 2, root.Y - textSize.Height / 2);
                drow_Node(root.Left);
                drow_Node(root.Right);
            }
        }

        private void generateRandomTree(object sender, EventArgs e)
        {

            Exam = false;
            str_Traversal = " ";

            str_Traversal = "";

            textBox1.Text = str_Traversal;
            Tree = new CTree(false, 5, picture.Width / 2);
            drow_Tree();
        }
        private void generateTree(object sender, EventArgs e)
        {
            Exam = false;
            var generateTreeForm = new GenerateForm();

            if (generateTreeForm.ShowDialog() == DialogResult.OK)
                if (generateTreeForm.levels + 1 != 0)
                {
                    str_Traversal = "";
                    textBox1.Text = str_Traversal;
                    Tree = new CTree(true, generateTreeForm.levels + 1, picture.Width / 2);
                    drow_Tree();
                }

        }

        private void Prefix_Click(object sender, EventArgs e)
        {
            if (Tree != null)
            {

                Exam = false;



                if (str_Traversal != "")
                    str_Traversal = str_Traversal.Remove(0, str_Traversal.Length);
                Prefix(Tree.Root);
                textBox1.Text = str_Traversal;

            }
        }
        private void Infix_Click(object sender, EventArgs e)
        {
            if (Tree != null)
            {

                Exam = false;

                if (str_Traversal != "")
                    str_Traversal = str_Traversal.Remove(0, str_Traversal.Length);
                Infix(Tree.Root);
                textBox1.Text = str_Traversal;
            }
        }
        private void Postfix_Click(object sender, EventArgs e)
        {
            if (Tree != null)
            {

                Exam = false;

                if (str_Traversal != "")
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

        private void Exam_Prefix_Click(object sender, EventArgs e)
        {
            Tree = new CTree(false, 5, picture.Width / 2);
            drow_Tree();
            Char_count = 0;
            Error_count = 0;
            textBox1.Text = "";
            if (str_Traversal != "" || Exam_str_Traversal != "")
            {
                str_Traversal = str_Traversal.Remove(0, str_Traversal.Length);
                Exam_str_Traversal = Exam_str_Traversal.Remove(0, Exam_str_Traversal.Length);
            }
            Prefix(Tree.Root);
            Exam = true;
            treeToolStripMenuItem.Enabled = false;
            exitToolStripMenuItem.Enabled = true;

        }
        private void Exam_Infix_Click(object sender, EventArgs e)
        {
            Tree = new CTree(false, 5, picture.Width / 2);
            drow_Tree();
            Char_count = 0;
            Error_count = 0;
            textBox1.Text = "";
            if (str_Traversal != "" || Exam_str_Traversal!= "")
            {
                str_Traversal = str_Traversal.Remove(0, str_Traversal.Length);
                Exam_str_Traversal = Exam_str_Traversal.Remove(0, Exam_str_Traversal.Length);
            }
            Infix(Tree.Root);
            Exam = true;
            treeToolStripMenuItem.Enabled = false;
            exitToolStripMenuItem.Enabled = true;
        }
        private void Exam_Postfix_Click(object sender, EventArgs e)
        {
            Tree = new CTree(false, 5, picture.Width / 2);
            drow_Tree();
            Char_count = 0;
            Error_count = 0;
            textBox1.Text = "";
            if (str_Traversal != "" || Exam_str_Traversal != "")
            {
                str_Traversal = str_Traversal.Remove(0, str_Traversal.Length);
                Exam_str_Traversal = Exam_str_Traversal.Remove(0, Exam_str_Traversal.Length);
            }
            Postfix(Tree.Root);
            Exam = true;
            treeToolStripMenuItem.Enabled = false;
            exitToolStripMenuItem.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exam = false;
            treeToolStripMenuItem.Enabled = true;
            Exam_passed(Tree.Root);
            str_Traversal = "";
            textBox1.Text = str_Traversal;
            drow_Tree();
            exitToolStripMenuItem.Enabled = false;
        }
    }
}
