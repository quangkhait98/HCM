using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace danctdl
{
    public partial class Form1 : Form
    {
        public int[] A;
        public int size;
        public Label[] bieudo;
        int ptm = 0;
        int tocdo;
        //string s;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

        }

    
        private void taonn_Click(object sender, EventArgs e)
        {
            taonn.Enabled = false;
            try
            {
                ptm = Convert.ToInt32(spt.Text);
            }
            catch
            {
                MessageBox.Show("Số phần tử vừa nhập vào không hợp lệ!");
                spt.Clear();
                taonn.Enabled = true; 
                return;
            }
            if ((ptm < 1) || (ptm > 40))
            {
                MessageBox.Show("0 < Giá trị nhập vào < 40");
                this.spt.Clear();
                taonn.Enabled = true;
                return;
            }
            ptm = Convert.ToInt32(spt.Text);
            cotgt.sizengang = 700 / ptm;
            cotgt.sizedoc = 400 / ptm;
            
            Random r = new Random();
            A = new int[ptm];
            for (int i = 0; i < ptm; i++)
            {
                A[i] = new int();
                A[i] = r.Next(1,ptm);
                xmang.Text += A[i].ToString() + " ";

            }
           vesort();
        
        }
        

        private void taolai_Click(object sender, EventArgs e)
        {
            taonn.Enabled = true;
            xmang.Text = string.Empty;
            spt.ResetText();
            panel1.Controls.Clear();
        }

        private void spt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        public void vesort()
        {
           
           bieudo = new Label[ptm];
            
            for (int i = 0; i < ptm; i++)
            {
                bieudo[i] = new Label();
                bieudo[i].AutoSize = false;
                bieudo[i].Location = new System.Drawing.Point(i*cotgt.sizengang,(400-A[i]*cotgt.sizedoc));
                bieudo[i].Size = new System.Drawing.Size(cotgt.sizengang,A[i]*cotgt.sizedoc);
                bieudo[i].BackColor = Color.Black;
                bieudo[i].BorderStyle = BorderStyle.FixedSingle;
                panel1.Controls.Add(bieudo[i]);
            }
        }

        private void sapxep_Click(object sender, EventArgs e)
        {
            ThreadStart ts = new ThreadStart(selectionsort);
            Thread thrd = new Thread(ts);
            thrd.Start();
          
        }

        public void selectionsort()
        {
            int min;
            for (int i = 0; i < ptm-1; i++)
            {
                min = i;
                for (int j = i + 1; j < ptm; j++)
                {
                    if(A[j]<A[min])
                    {
                        min = j;
                    }
                }
                if(min!=i)
                {
                    tomau(i);
                    doicho(i,min);                    
                    Thread.Sleep(tocdo);
                    capnhat();
                }
                else
                {
                    tomau(i);
                }
            }
           tomau(ptm-1);  
                    
        }     
        void doicho(int x, int y)
        {
            int tempcx = bieudo[x].Size.Height;
            bieudo[x].Size = new System.Drawing.Size(bieudo[x].Size.Width, bieudo[y].Size.Height);
            bieudo[x].Location = new System.Drawing.Point(bieudo[x].Location.X, 400 - bieudo[y].Size.Height);
            bieudo[y].Size = new System.Drawing.Size(bieudo[y].Size.Width, tempcx);
            bieudo[y].Location = new System.Drawing.Point(bieudo[y].Location.X, 400 - tempcx);
            int temp = A[x];
            A[x] = A[y];
            A[y] = temp;
        }
       void capnhat()
        {
            xmang.Text = string.Empty;
            for (int i=0;i<ptm;i++)
            {
                xmang.Text += A[i].ToString() + " ";
            }       
        }
        void tomau(int x)
        {
            bieudo[x].BackColor = Color.Yellow;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tocdo = trackBar1.Value;
        }
    }
}
