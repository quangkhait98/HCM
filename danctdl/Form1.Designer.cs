namespace danctdl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.spt = new System.Windows.Forms.TextBox();
            this.taonn = new System.Windows.Forms.Button();
            this.xmang = new System.Windows.Forms.Label();
            this.taolai = new System.Windows.Forms.Button();
            this.sapxep = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 400);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(719, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tạo giá trị mảng : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(714, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng phần tử : ";
            // 
            // spt
            // 
            this.spt.Location = new System.Drawing.Point(805, 98);
            this.spt.Name = "spt";
            this.spt.Size = new System.Drawing.Size(100, 20);
            this.spt.TabIndex = 5;
            this.spt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.spt_KeyPress);
            // 
            // taonn
            // 
            this.taonn.Location = new System.Drawing.Point(817, 131);
            this.taonn.Name = "taonn";
            this.taonn.Size = new System.Drawing.Size(75, 23);
            this.taonn.TabIndex = 6;
            this.taonn.Text = "Ngẫu nhiên";
            this.taonn.UseVisualStyleBackColor = true;
            this.taonn.Click += new System.EventHandler(this.taonn_Click);
            // 
            // xmang
            // 
            this.xmang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.xmang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xmang.Location = new System.Drawing.Point(28, 416);
            this.xmang.Name = "xmang";
            this.xmang.Size = new System.Drawing.Size(558, 23);
            this.xmang.TabIndex = 7;
            this.xmang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taolai
            // 
            this.taolai.Location = new System.Drawing.Point(817, 161);
            this.taolai.Name = "taolai";
            this.taolai.Size = new System.Drawing.Size(75, 23);
            this.taolai.TabIndex = 8;
            this.taolai.Text = "Tạo lại";
            this.taolai.UseVisualStyleBackColor = true;
            this.taolai.Click += new System.EventHandler(this.taolai_Click);
            // 
            // sapxep
            // 
            this.sapxep.Location = new System.Drawing.Point(817, 191);
            this.sapxep.Name = "sapxep";
            this.sapxep.Size = new System.Drawing.Size(75, 23);
            this.sapxep.TabIndex = 9;
            this.sapxep.Text = "Sắp xếp";
            this.sapxep.UseVisualStyleBackColor = true;
            this.sapxep.Click += new System.EventHandler(this.sapxep_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(801, 220);
            this.trackBar1.Maximum = 2000;
            this.trackBar1.Minimum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(708, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "     Tốc độ :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(921, 475);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.sapxep);
            this.Controls.Add(this.xmang);
            this.Controls.Add(this.taolai);
            this.Controls.Add(this.taonn);
            this.Controls.Add(this.spt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox spt;
        private System.Windows.Forms.Button taonn;
        private System.Windows.Forms.Label xmang;
        private System.Windows.Forms.Button taolai;
        private System.Windows.Forms.Button sapxep;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
    }
}

