namespace NQueens
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
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
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
          this.components = new System.ComponentModel.Container();
          this.splitter1 = new System.Windows.Forms.Splitter();
          this.label1 = new System.Windows.Forms.Label();
          this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
          this.button1 = new System.Windows.Forms.Button();
          this.trackBar1 = new System.Windows.Forms.TrackBar();
          this.listBox1 = new System.Windows.Forms.ListBox();
          this.label2 = new System.Windows.Forms.Label();
          this.panel1 = new System.Windows.Forms.Panel();
          this.panel2 = new System.Windows.Forms.Panel();
          this.timer1 = new System.Windows.Forms.Timer(this.components);
          ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
          this.SuspendLayout();
          // 
          // splitter1
          // 
          this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
          this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
          this.splitter1.Location = new System.Drawing.Point(650, 0);
          this.splitter1.MinSize = 12;
          this.splitter1.Name = "splitter1";
          this.splitter1.Size = new System.Drawing.Size(134, 562);
          this.splitter1.TabIndex = 0;
          this.splitter1.TabStop = false;
          // 
          // label1
          // 
          this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
          this.label1.AutoSize = true;
          this.label1.Location = new System.Drawing.Point(666, 21);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(98, 13);
          this.label1.TabIndex = 1;
          this.label1.Text = "Number Of Queens";
          // 
          // numericUpDown1
          // 
          this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
          this.numericUpDown1.AutoSize = true;
          this.numericUpDown1.BackColor = System.Drawing.SystemColors.Control;
          this.numericUpDown1.InterceptArrowKeys = false;
          this.numericUpDown1.Location = new System.Drawing.Point(669, 37);
          this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
          this.numericUpDown1.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
          this.numericUpDown1.Name = "numericUpDown1";
          this.numericUpDown1.ReadOnly = true;
          this.numericUpDown1.Size = new System.Drawing.Size(95, 20);
          this.numericUpDown1.TabIndex = 12;
          this.numericUpDown1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
          this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
          // 
          // button1
          // 
          this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
          this.button1.AutoSize = true;
          this.button1.BackColor = System.Drawing.SystemColors.Control;
          this.button1.Location = new System.Drawing.Point(669, 78);
          this.button1.Name = "button1";
          this.button1.Size = new System.Drawing.Size(95, 49);
          this.button1.TabIndex = 13;
          this.button1.Text = "Start";
          this.button1.UseVisualStyleBackColor = false;
          this.button1.Click += new System.EventHandler(this.button1_Click);
          // 
          // trackBar1
          // 
          this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
          this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
          this.trackBar1.Location = new System.Drawing.Point(669, 133);
          this.trackBar1.Maximum = 2000;
          this.trackBar1.Minimum = 100;
          this.trackBar1.Name = "trackBar1";
          this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
          this.trackBar1.Size = new System.Drawing.Size(92, 45);
          this.trackBar1.TabIndex = 14;
          this.trackBar1.Value = 2000;
          this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
          // 
          // listBox1
          // 
          this.listBox1.AllowDrop = true;
          this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.listBox1.FormattingEnabled = true;
          this.listBox1.HorizontalScrollbar = true;
          this.listBox1.Location = new System.Drawing.Point(670, 205);
          this.listBox1.Name = "listBox1";
          this.listBox1.Size = new System.Drawing.Size(95, 342);
          this.listBox1.TabIndex = 15;
          this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
          // 
          // label2
          // 
          this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
          this.label2.AutoSize = true;
          this.label2.Location = new System.Drawing.Point(666, 189);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(50, 13);
          this.label2.TabIndex = 16;
          this.label2.Text = "Solutions";
          // 
          // panel1
          // 
          this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.panel1.AutoSize = true;
          this.panel1.Location = new System.Drawing.Point(132, 149);
          this.panel1.Name = "panel1";
          this.panel1.Size = new System.Drawing.Size(389, 380);
          this.panel1.TabIndex = 17;
          // 
          // panel2
          // 
          this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.panel2.AutoSize = true;
          this.panel2.Location = new System.Drawing.Point(132, 0);
          this.panel2.Name = "panel2";
          this.panel2.Size = new System.Drawing.Size(389, 143);
          this.panel2.TabIndex = 0;
          this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
          // 
          // timer1
          // 
          this.timer1.Interval = 2000;
          this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
          // 
          // Form1
          // 
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
          this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
          this.BackColor = System.Drawing.SystemColors.ButtonFace;
          this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
          this.ClientSize = new System.Drawing.Size(784, 562);
          this.Controls.Add(this.panel2);
          this.Controls.Add(this.panel1);
          this.Controls.Add(this.label2);
          this.Controls.Add(this.listBox1);
          this.Controls.Add(this.trackBar1);
          this.Controls.Add(this.button1);
          this.Controls.Add(this.numericUpDown1);
          this.Controls.Add(this.label1);
          this.Controls.Add(this.splitter1);
          this.Cursor = System.Windows.Forms.Cursors.Default;
          this.KeyPreview = true;
          this.MinimumSize = new System.Drawing.Size(800, 600);
          this.Name = "Form1";
          this.Text = "N-Queens";
          this.Load += new System.EventHandler(this.Form1_Load);
          this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
          this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
          ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Splitter splitter1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.NumericUpDown numericUpDown1;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.TrackBar trackBar1;
      private System.Windows.Forms.ListBox listBox1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Timer timer1;





   }
}

