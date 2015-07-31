using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NQueens
{
   public partial class Form1 : Form
   {

      int counter;
      static int n = 4;
      int[] conf;
      bool[] rows;
      bool[] diag1;
      bool[] diag2;
      Stack<Pair> stk;
      Pair p;
      List<int[]> solList;

      private void Init()
      {
         counter = 0;
         n = Convert.ToInt32(numericUpDown1.Value);
         conf = Enumerable.Repeat(-1, n).ToArray();
         rows = new bool[n];
         diag1 = new bool[2 * n - 1];
         diag2 = new bool[2 * n - 1];
         stk = new Stack<Pair>();
         p = new Pair(-1, 0);
         stk.Push(p);
         solList = new List<int[]>();
         listBox1.Items.Clear();
      }
      public Form1()
      {
         InitializeComponent();
         Init();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
      }  
      private void Form1_Paint(object sender, PaintEventArgs e)
      {
         printCurrentConf();
      }
      private void printCurrentConf()
      {
         Graphics g = panel1.CreateGraphics();
         Graphics h = panel2.CreateGraphics();
         Brush brush1 = new SolidBrush(Color.Gray);
         Brush brush2 = new SolidBrush(Color.Black);
         Brush brush3 = new SolidBrush(Color.Blue);
         Brush brush4 = new SolidBrush(Color.Red);
         Brush brush;
         int size = panel1.Height / n;

         if (panel1.Width < panel1.Height)
         {
            size = panel1.Width / n;
         }

         for (int i = 0; i != n; ++i)
         {
            for (int j = 0; j != n; ++j)
            {

               if ((i + j) % 2 == 0)
               {
                  brush = brush1;
               }
               else
               {
                  brush = brush2;
               }
               g.FillRectangle(brush, i * size, j * size, size, size);
            }
         }
         for (int i = 0; i != n; ++i)
         {
            if (conf[i] == -1)
            {
               h.FillEllipse(brush3, i * size, panel2.Height - size, size, size);
            }
            else if (i == 0)
            {
               g.FillEllipse(brush3, i * size, conf[i] * size, size, size);
            }
            else
            {
               for (int j = 0; j != i; ++j)
               {
                  if (conf[j] == conf[i] || (conf[j] - j + n - 1) == (conf[i] - i + n - 1) || (conf[j] + j) == (conf[i] + i))
                  {
                     g.FillEllipse(brush4, j * size, conf[j] * size, size, size);
                  }
                  else
                  {
                     g.FillEllipse(brush3, j * size, conf[j] * size, size, size);
                  }
               }
            }
            g.FillEllipse(brush3, i * size, conf[i] * size, size, size);
         }
      }
      
      public class Pair
      {
         public int row;
         public int col;
         public Pair(int aRow, int aCol)
         {
            row = aRow;
            col = aCol;
         }
      }

      private void putQueen(int row, int col)
      {
         rows[row] = true;
         diag1[row - col + n - 1] = true;
         diag2[row + col] = true;
      }
      private void takeQueen(int row, int col)
      {
         rows[row] = false;
         diag1[row - col + n - 1] = false;
         diag2[row + col] = false;
      }      
      bool checkQueen(int row, int col)
      {
	      return !rows[row] && !diag1[row - col + n - 1] && !diag2[row + col];
      }
     
      public class Item
      {
         public string strText;
         public string strValue;
         public override string ToString()
         {
            return this.strText;
         }
      }
      public void Draw()
      {
          if (stk.Count > 0)
          {
              ++stk.Peek().row;
          }
          
		   int row = stk.Peek().row;
		   int col = stk.Peek().col;
		
		   if(col == 0 && row == n)
		   {
                conf[col] = -1;
                numericUpDown1.Enabled = true;
                button1.Enabled = true;
                listBox1.Enabled = true;
                timer1.Enabled = false;
		   }
         if(col == n)
         {
             ++counter;
             int[] a = new int[conf.Length];
             conf.CopyTo(a, 0);
             solList.Add(a);
             Item obj = new Item();
             obj.strText = "Solution " + counter.ToString();
             obj.strValue = counter.ToString();
             this.listBox1.Items.Add(obj);
		       stk.Pop();
	          takeQueen(stk.Peek().row, stk.Peek().col);
         }
	      else if(row == n)
		   {
            conf[col] = -1;
            stk.Pop();
            if (stk.Count() != 0)
            {
               takeQueen(stk.Peek().row, stk.Peek().col);
            }
		   }
		   else
		   {
            conf[col] = row;
			   if(checkQueen(row, col))
			   {
		         putQueen(row, col);
               p = new Pair(-1, col + 1);
	  	         stk.Push(p);
		      }
		   }
      }
     
      private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
      {
         Item obj = this.listBox1.SelectedItem as Item;
         int order = Convert.ToInt32(obj.strValue);
         solList[order - 1].CopyTo(conf, 0);
         Refresh();
         printCurrentConf();
      }
      private void numericUpDown1_ValueChanged(object sender, EventArgs e)
      {
         Init();
         Refresh();
         printCurrentConf();
         timer1.Enabled = false;
      }
      private void button1_Click(object sender, EventArgs e)
      {
         Init();
         timer1.Enabled = true;
         numericUpDown1.Enabled = false;
         button1.Enabled = false;
         listBox1.Enabled = false;
      }
      private void Form1_KeyDown(object sender, KeyEventArgs e)
      {
         if(e.KeyCode == Keys.Space)
         {
             if (timer1.Enabled)
             {
                 timer1.Enabled = false;
             }
             else
             {
                 timer1.Enabled = true;
             }
         }
         else if (e.KeyCode == Keys.Down)
         {
             if (!timer1.Enabled)
             {
                 Draw();
                 Refresh();
                 printCurrentConf();
             }
         }
         else if (e.KeyCode == Keys.Escape)
         {
             Init();
             numericUpDown1.Enabled = true;
             button1.Enabled = true;
             listBox1.Enabled = true;
             timer1.Enabled = false;
             Refresh();
             printCurrentConf();
         }
      }
      private void trackBar1_Scroll(object sender, EventArgs e)
      {
         timer1.Interval = trackBar1.Value;
      }
      private void timer1_Tick(object sender, EventArgs e)
      {
         Draw();
         Refresh();
         printCurrentConf();
      }
      private void groupBox1_Enter(object sender, EventArgs e)
      {

      }
      private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
      {

      }

      private void panel2_Paint(object sender, PaintEventArgs e)
      {

      }
   }
}
