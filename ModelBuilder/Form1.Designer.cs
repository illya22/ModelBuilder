namespace ModelBuilder
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.FractalPictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.KochpictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.MandelbrotpictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.LoadImagebotton = new System.Windows.Forms.Button();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.LSMBoundary = new System.Windows.Forms.Button();
            this.LSMbutton = new System.Windows.Forms.Button();
            this.LSMnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FractalPictureBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KochpictureBox)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MandelbrotpictureBox)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1258, 929);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.FractalPictureBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1250, 896);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(762, 14);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fractal Tree",
            "Serpinskiy Carpet",
            "Serpinskiy Triangle"});
            this.comboBox1.Location = new System.Drawing.Point(457, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FractalPictureBox
            // 
            this.FractalPictureBox.Location = new System.Drawing.Point(6, 48);
            this.FractalPictureBox.Name = "FractalPictureBox";
            this.FractalPictureBox.Size = new System.Drawing.Size(1238, 851);
            this.FractalPictureBox.TabIndex = 0;
            this.FractalPictureBox.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numericUpDown3);
            this.tabPage2.Controls.Add(this.numericUpDown2);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.KochpictureBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1250, 896);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(896, 12);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown3.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(720, 12);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown2.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Snowflake Koch",
            "Gosper curve"});
            this.comboBox2.Location = new System.Drawing.Point(541, 11);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // KochpictureBox
            // 
            this.KochpictureBox.Location = new System.Drawing.Point(6, 75);
            this.KochpictureBox.Name = "KochpictureBox";
            this.KochpictureBox.Size = new System.Drawing.Size(831, 726);
            this.KochpictureBox.TabIndex = 5;
            this.KochpictureBox.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.MandelbrotpictureBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1250, 896);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MandelbrotpictureBox
            // 
            this.MandelbrotpictureBox.Location = new System.Drawing.Point(6, 20);
            this.MandelbrotpictureBox.Name = "MandelbrotpictureBox";
            this.MandelbrotpictureBox.Size = new System.Drawing.Size(1227, 870);
            this.MandelbrotpictureBox.TabIndex = 0;
            this.MandelbrotpictureBox.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ImageBox);
            this.tabPage4.Controls.Add(this.LoadImagebotton);
            this.tabPage4.Controls.Add(this.textBoxAnswer);
            this.tabPage4.Controls.Add(this.LSMBoundary);
            this.tabPage4.Controls.Add(this.LSMbutton);
            this.tabPage4.Controls.Add(this.LSMnumericUpDown);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1250, 896);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ImageBox
            // 
            this.ImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImageBox.Location = new System.Drawing.Point(256, 17);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(975, 841);
            this.ImageBox.TabIndex = 5;
            this.ImageBox.TabStop = false;
            // 
            // LoadImagebotton
            // 
            this.LoadImagebotton.Location = new System.Drawing.Point(86, 6);
            this.LoadImagebotton.Name = "LoadImagebotton";
            this.LoadImagebotton.Size = new System.Drawing.Size(140, 29);
            this.LoadImagebotton.TabIndex = 4;
            this.LoadImagebotton.Text = "Load Image";
            this.LoadImagebotton.UseVisualStyleBackColor = true;
            this.LoadImagebotton.Click += new System.EventHandler(this.LoadImagebotton_Click);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(46, 157);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(180, 27);
            this.textBoxAnswer.TabIndex = 3;
            // 
            // LSMBoundary
            // 
            this.LSMBoundary.Location = new System.Drawing.Point(59, 87);
            this.LSMBoundary.Name = "LSMBoundary";
            this.LSMBoundary.Size = new System.Drawing.Size(167, 29);
            this.LSMBoundary.TabIndex = 2;
            this.LSMBoundary.Text = "Set Boundary";
            this.LSMBoundary.UseVisualStyleBackColor = true;
            this.LSMBoundary.Click += new System.EventHandler(this.LSMBoundary_Click);
            // 
            // LSMbutton
            // 
            this.LSMbutton.Location = new System.Drawing.Point(119, 122);
            this.LSMbutton.Name = "LSMbutton";
            this.LSMbutton.Size = new System.Drawing.Size(94, 29);
            this.LSMbutton.TabIndex = 1;
            this.LSMbutton.Text = "LSM";
            this.LSMbutton.UseVisualStyleBackColor = true;
            this.LSMbutton.Click += new System.EventHandler(this.LSMbutton_Click);
            // 
            // LSMnumericUpDown
            // 
            this.LSMnumericUpDown.Location = new System.Drawing.Point(76, 54);
            this.LSMnumericUpDown.Name = "LSMnumericUpDown";
            this.LSMnumericUpDown.Size = new System.Drawing.Size(150, 27);
            this.LSMnumericUpDown.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 953);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FractalPictureBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KochpictureBox)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MandelbrotpictureBox)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMnumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox comboBox1;
        private PictureBox FractalPictureBox;
        private NumericUpDown numericUpDown1;
        private PictureBox KochpictureBox;
        private ComboBox comboBox2;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private TabPage tabPage3;
        private PictureBox MandelbrotpictureBox;
        private System.Windows.Forms.Timer timer1;
        private TabPage tabPage4;
        private NumericUpDown LSMnumericUpDown;
        private Button LSMbutton;
        private Button LoadImagebotton;
        private TextBox textBoxAnswer;
        private Button LSMBoundary;
        private PictureBox ImageBox;
    }
}