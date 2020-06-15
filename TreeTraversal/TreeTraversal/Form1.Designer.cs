namespace TreeTraversal
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.answerPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.treeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateRandomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateFullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.префиксныйОбходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инфиксныйОбходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.постфиксныйОбходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picture = new System.Windows.Forms.PictureBox();
            this.answerPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // answerPanel
            // 
            this.answerPanel.BackColor = System.Drawing.Color.SlateBlue;
            this.answerPanel.Controls.Add(this.textBox1);
            this.answerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.answerPanel.Location = new System.Drawing.Point(0, 561);
            this.answerPanel.Name = "answerPanel";
            this.answerPanel.Size = new System.Drawing.Size(984, 50);
            this.answerPanel.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(275, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(450, 25);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.treeToolStripMenuItem,
            this.examToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(984, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // treeToolStripMenuItem
            // 
            this.treeToolStripMenuItem.AutoSize = false;
            this.treeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(0)))), ((int)(((byte)(203)))));
            this.treeToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.treeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.treeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateRandomToolStripMenuItem,
            this.generateFullToolStripMenuItem,
            this.preOrderToolStripMenuItem,
            this.inOrderToolStripMenuItem,
            this.postOrderToolStripMenuItem});
            this.treeToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.treeToolStripMenuItem.Name = "treeToolStripMenuItem";
            this.treeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 0, 4);
            this.treeToolStripMenuItem.Size = new System.Drawing.Size(122, 25);
            this.treeToolStripMenuItem.Text = "Дерево";
            this.treeToolStripMenuItem.Click += new System.EventHandler(this.treeToolStripMenuItem_Click);
            // 
            // generateRandomToolStripMenuItem
            // 
            this.generateRandomToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(92)))), ((int)(((byte)(251)))));
            this.generateRandomToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.generateRandomToolStripMenuItem.Name = "generateRandomToolStripMenuItem";
            this.generateRandomToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.generateRandomToolStripMenuItem.Text = "Сгенерировать случайное";
            this.generateRandomToolStripMenuItem.Click += new System.EventHandler(this.generateRandomTree);
            // 
            // generateFullToolStripMenuItem
            // 
            this.generateFullToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(0)))), ((int)(((byte)(203)))));
            this.generateFullToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.generateFullToolStripMenuItem.Name = "generateFullToolStripMenuItem";
            this.generateFullToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.generateFullToolStripMenuItem.Text = "Сгенерировать полное";
            this.generateFullToolStripMenuItem.Click += new System.EventHandler(this.generateTree);
            // 
            // preOrderToolStripMenuItem
            // 
            this.preOrderToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(1)))), ((int)(((byte)(153)))));
            this.preOrderToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.preOrderToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.preOrderToolStripMenuItem.Name = "preOrderToolStripMenuItem";
            this.preOrderToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.preOrderToolStripMenuItem.Text = "Префиксный обход";
            this.preOrderToolStripMenuItem.Click += new System.EventHandler(this.Prefix_Click);
            // 
            // inOrderToolStripMenuItem
            // 
            this.inOrderToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(0)))), ((int)(((byte)(123)))));
            this.inOrderToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inOrderToolStripMenuItem.Name = "inOrderToolStripMenuItem";
            this.inOrderToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.inOrderToolStripMenuItem.Text = "Инфиксный обход";
            this.inOrderToolStripMenuItem.Click += new System.EventHandler(this.Infix_Click);
            // 
            // postOrderToolStripMenuItem
            // 
            this.postOrderToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(1)))), ((int)(((byte)(98)))));
            this.postOrderToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.postOrderToolStripMenuItem.Name = "postOrderToolStripMenuItem";
            this.postOrderToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.postOrderToolStripMenuItem.Text = "Постфиксный обход";
            this.postOrderToolStripMenuItem.Click += new System.EventHandler(this.Postfix_Click);
            // 
            // examToolStripMenuItem
            // 
            this.examToolStripMenuItem.AutoSize = false;
            this.examToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(92)))), ((int)(((byte)(251)))));
            this.examToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.префиксныйОбходToolStripMenuItem,
            this.инфиксныйОбходToolStripMenuItem,
            this.постфиксныйОбходToolStripMenuItem});
            this.examToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.examToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.examToolStripMenuItem.Name = "examToolStripMenuItem";
            this.examToolStripMenuItem.Size = new System.Drawing.Size(100, 25);
            this.examToolStripMenuItem.Text = "Экзамен";
            this.examToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // префиксныйОбходToolStripMenuItem
            // 
            this.префиксныйОбходToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(92)))), ((int)(((byte)(251)))));
            this.префиксныйОбходToolStripMenuItem.Name = "префиксныйОбходToolStripMenuItem";
            this.префиксныйОбходToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.префиксныйОбходToolStripMenuItem.Text = "Префиксный обход";
            this.префиксныйОбходToolStripMenuItem.Click += new System.EventHandler(this.Exam_Prefix_Click);
            // 
            // инфиксныйОбходToolStripMenuItem
            // 
            this.инфиксныйОбходToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(0)))), ((int)(((byte)(203)))));
            this.инфиксныйОбходToolStripMenuItem.Name = "инфиксныйОбходToolStripMenuItem";
            this.инфиксныйОбходToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.инфиксныйОбходToolStripMenuItem.Text = "Инфиксный обход";
            this.инфиксныйОбходToolStripMenuItem.Click += new System.EventHandler(this.Exam_Infix_Click);
            // 
            // постфиксныйОбходToolStripMenuItem
            // 
            this.постфиксныйОбходToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(1)))), ((int)(((byte)(153)))));
            this.постфиксныйОбходToolStripMenuItem.Name = "постфиксныйОбходToolStripMenuItem";
            this.постфиксныйОбходToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.постфиксныйОбходToolStripMenuItem.Text = "Постфиксный обход";
            this.постфиксныйОбходToolStripMenuItem.Click += new System.EventHandler(this.Exam_Postfix_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.AutoSize = false;
            this.optionsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(0)))), ((int)(((byte)(203)))));
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(100, 25);
            this.optionsToolStripMenuItem.Text = "Опции";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.AutoSize = false;
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(92)))), ((int)(((byte)(251)))));
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(100, 25);
            this.helpToolStripMenuItem.Text = "Помощь";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(12, 28);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(960, 527);
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.answerPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1000, 650);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "Form1";
            this.Text = "Tree Traversal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.answerPanel.ResumeLayout(false);
            this.answerPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel answerPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem treeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateRandomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateFullToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postOrderToolStripMenuItem;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem префиксныйОбходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инфиксныйОбходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem постфиксныйОбходToolStripMenuItem;
    }
}

