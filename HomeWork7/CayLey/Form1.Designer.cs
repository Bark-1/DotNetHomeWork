
namespace CayLey
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_draw = new System.Windows.Forms.Button();
            this.label_per1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_pen = new System.Windows.Forms.ComboBox();
            this.label_pen = new System.Windows.Forms.Label();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.textBox_leng = new System.Windows.Forms.TextBox();
            this.label_leng = new System.Windows.Forms.Label();
            this.label_n = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_th2 = new System.Windows.Forms.TextBox();
            this.label_th2 = new System.Windows.Forms.Label();
            this.textBox_th1 = new System.Windows.Forms.TextBox();
            this.label_th1 = new System.Windows.Forms.Label();
            this.textBox_per2 = new System.Windows.Forms.TextBox();
            this.label_per2 = new System.Windows.Forms.Label();
            this.textBox_per1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_draw
            // 
            this.button_draw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_draw.Location = new System.Drawing.Point(68, 80);
            this.button_draw.Name = "button_draw";
            this.button_draw.Size = new System.Drawing.Size(127, 57);
            this.button_draw.TabIndex = 0;
            this.button_draw.Text = "draw";
            this.button_draw.UseVisualStyleBackColor = true;
            this.button_draw.Click += new System.EventHandler(this.button_draw_Click);
            // 
            // label_per1
            // 
            this.label_per1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_per1.AutoSize = true;
            this.label_per1.Location = new System.Drawing.Point(31, 33);
            this.label_per1.Name = "label_per1";
            this.label_per1.Size = new System.Drawing.Size(70, 24);
            this.label_per1.TabIndex = 5;
            this.label_per1.Text = "per1:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 250);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox_pen);
            this.panel2.Controls.Add(this.label_pen);
            this.panel2.Controls.Add(this.textBox_n);
            this.panel2.Controls.Add(this.textBox_leng);
            this.panel2.Controls.Add(this.label_leng);
            this.panel2.Controls.Add(this.label_n);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(370, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 250);
            this.panel2.TabIndex = 6;
            // 
            // comboBox_pen
            // 
            this.comboBox_pen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_pen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_pen.FormattingEnabled = true;
            this.comboBox_pen.Items.AddRange(new System.Drawing.Pen[] {
            System.Drawing.Pens.Blue,
            System.Drawing.Pens.Black,
            System.Drawing.Pens.Red,
            System.Drawing.Pens.Yellow}) ;
            this.comboBox_pen.DisplayMember = "Color";
            this.comboBox_pen.Location = new System.Drawing.Point(110, 127);
            this.comboBox_pen.Name = "comboBox_pen";
            this.comboBox_pen.Size = new System.Drawing.Size(209, 32);
            this.comboBox_pen.TabIndex = 6;
            this.comboBox_pen.SelectedIndexChanged += new System.EventHandler(this.comboBox_pen_SelectedIndexChanged);
            // 
            // label_pen
            // 
            this.label_pen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_pen.AutoSize = true;
            this.label_pen.Location = new System.Drawing.Point(41, 127);
            this.label_pen.Name = "label_pen";
            this.label_pen.Size = new System.Drawing.Size(58, 24);
            this.label_pen.TabIndex = 5;
            this.label_pen.Text = "pen:";
            // 
            // textBox_n
            // 
            this.textBox_n.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_n.Location = new System.Drawing.Point(110, 33);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(209, 35);
            this.textBox_n.TabIndex = 2;
            this.textBox_n.TextChanged += new System.EventHandler(this.textBox_n_TextChanged);
            // 
            // textBox_leng
            // 
            this.textBox_leng.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_leng.Location = new System.Drawing.Point(110, 80);
            this.textBox_leng.Name = "textBox_leng";
            this.textBox_leng.Size = new System.Drawing.Size(209, 35);
            this.textBox_leng.TabIndex = 4;
            this.textBox_leng.TextChanged += new System.EventHandler(this.textBox_leng_TextChanged);
            // 
            // label_leng
            // 
            this.label_leng.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_leng.AutoSize = true;
            this.label_leng.Location = new System.Drawing.Point(5, 83);
            this.label_leng.Name = "label_leng";
            this.label_leng.Size = new System.Drawing.Size(94, 24);
            this.label_leng.TabIndex = 3;
            this.label_leng.Text = "length:";
            // 
            // label_n
            // 
            this.label_n.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_n.AutoSize = true;
            this.label_n.Location = new System.Drawing.Point(65, 36);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(34, 24);
            this.label_n.TabIndex = 1;
            this.label_n.Text = "n:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox_th2);
            this.panel3.Controls.Add(this.label_th2);
            this.panel3.Controls.Add(this.textBox_th1);
            this.panel3.Controls.Add(this.label_th1);
            this.panel3.Controls.Add(this.textBox_per2);
            this.panel3.Controls.Add(this.label_per2);
            this.panel3.Controls.Add(this.textBox_per1);
            this.panel3.Controls.Add(this.label_per1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(370, 250);
            this.panel3.TabIndex = 7;
            // 
            // textBox_th2
            // 
            this.textBox_th2.Location = new System.Drawing.Point(126, 180);
            this.textBox_th2.Name = "textBox_th2";
            this.textBox_th2.Size = new System.Drawing.Size(193, 35);
            this.textBox_th2.TabIndex = 11;
            this.textBox_th2.TextChanged += new System.EventHandler(this.textBox_th2_TextChanged);
            // 
            // label_th2
            // 
            this.label_th2.AutoSize = true;
            this.label_th2.Location = new System.Drawing.Point(43, 183);
            this.label_th2.Name = "label_th2";
            this.label_th2.Size = new System.Drawing.Size(58, 24);
            this.label_th2.TabIndex = 10;
            this.label_th2.Text = "th2:";
            // 
            // textBox_th1
            // 
            this.textBox_th1.Location = new System.Drawing.Point(126, 130);
            this.textBox_th1.Name = "textBox_th1";
            this.textBox_th1.Size = new System.Drawing.Size(193, 35);
            this.textBox_th1.TabIndex = 7;
            this.textBox_th1.TextChanged += new System.EventHandler(this.textBox_th1_TextChanged);
            // 
            // label_th1
            // 
            this.label_th1.AutoSize = true;
            this.label_th1.Location = new System.Drawing.Point(43, 130);
            this.label_th1.Name = "label_th1";
            this.label_th1.Size = new System.Drawing.Size(58, 24);
            this.label_th1.TabIndex = 9;
            this.label_th1.Text = "th1:";
            // 
            // textBox_per2
            // 
            this.textBox_per2.Location = new System.Drawing.Point(126, 80);
            this.textBox_per2.Name = "textBox_per2";
            this.textBox_per2.Size = new System.Drawing.Size(193, 35);
            this.textBox_per2.TabIndex = 8;
            this.textBox_per2.TextChanged += new System.EventHandler(this.textBox_per2_TextChanged);
            // 
            // label_per2
            // 
            this.label_per2.AutoSize = true;
            this.label_per2.Location = new System.Drawing.Point(31, 80);
            this.label_per2.Name = "label_per2";
            this.label_per2.Size = new System.Drawing.Size(70, 24);
            this.label_per2.TabIndex = 7;
            this.label_per2.Text = "per2:";
            // 
            // textBox_per1
            // 
            this.textBox_per1.Location = new System.Drawing.Point(126, 30);
            this.textBox_per1.Name = "textBox_per1";
            this.textBox_per1.Size = new System.Drawing.Size(193, 35);
            this.textBox_per1.TabIndex = 6;
            this.textBox_per1.TextChanged += new System.EventHandler(this.textBox_per1_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button_draw);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(715, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(259, 250);
            this.panel4.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 1029);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1000, 1100);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_draw;
        private System.Windows.Forms.Label label_per1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.TextBox textBox_leng;
        private System.Windows.Forms.Label label_leng;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_per1;
        private System.Windows.Forms.TextBox textBox_per2;
        private System.Windows.Forms.Label label_per2;
        private System.Windows.Forms.TextBox textBox_th1;
        private System.Windows.Forms.Label label_th1;
        private System.Windows.Forms.TextBox textBox_th2;
        private System.Windows.Forms.Label label_th2;
        private System.Windows.Forms.ComboBox comboBox_pen;
        private System.Windows.Forms.Label label_pen;
    }
}

