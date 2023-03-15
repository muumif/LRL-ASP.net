namespace Math_quiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            showpicbutton1 = new Button();
            clearpicbutton2 = new Button();
            backcolorbutton3 = new Button();
            closebutton4 = new Button();
            openFileDialog1 = new OpenFileDialog();
            colorDialog1 = new ColorDialog();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(checkBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(880, 446);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 395);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 404);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(63, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Stretch";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(showpicbutton1);
            flowLayoutPanel1.Controls.Add(clearpicbutton2);
            flowLayoutPanel1.Controls.Add(backcolorbutton3);
            flowLayoutPanel1.Controls.Add(closebutton4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(135, 404);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(742, 39);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // showpicbutton1
            // 
            showpicbutton1.AutoSize = true;
            showpicbutton1.Location = new Point(649, 3);
            showpicbutton1.Name = "showpicbutton1";
            showpicbutton1.Size = new Size(90, 25);
            showpicbutton1.TabIndex = 0;
            showpicbutton1.Text = "Show Picture";
            showpicbutton1.UseVisualStyleBackColor = true;
            showpicbutton1.Click += button1_Click;
            // 
            // clearpicbutton2
            // 
            clearpicbutton2.AutoSize = true;
            clearpicbutton2.Location = new Point(533, 3);
            clearpicbutton2.Name = "clearpicbutton2";
            clearpicbutton2.Size = new Size(110, 25);
            clearpicbutton2.TabIndex = 1;
            clearpicbutton2.Text = "Clear the picture";
            clearpicbutton2.UseVisualStyleBackColor = true;
            clearpicbutton2.Click += button2_Click;
            // 
            // backcolorbutton3
            // 
            backcolorbutton3.AutoSize = true;
            backcolorbutton3.Location = new Point(370, 3);
            backcolorbutton3.Name = "backcolorbutton3";
            backcolorbutton3.Size = new Size(157, 25);
            backcolorbutton3.TabIndex = 2;
            backcolorbutton3.Text = "Set the background color";
            backcolorbutton3.UseVisualStyleBackColor = true;
            backcolorbutton3.Click += button3_Click;
            // 
            // closebutton4
            // 
            closebutton4.AutoSize = true;
            closebutton4.Location = new Point(289, 3);
            closebutton4.Name = "closebutton4";
            closebutton4.Size = new Size(75, 25);
            closebutton4.TabIndex = 3;
            closebutton4.Text = "Close";
            closebutton4.UseVisualStyleBackColor = true;
            closebutton4.Click += button4_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
            openFileDialog1.Title = "Select picture file";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 446);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button showpicbutton1;
        private Button clearpicbutton2;
        private Button backcolorbutton3;
        private Button closebutton4;
        private OpenFileDialog openFileDialog1;
        private ColorDialog colorDialog1;
    }
}