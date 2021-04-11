namespace Homework07_1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.leng = new System.Windows.Forms.GroupBox();
            this.lengValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nValue = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.perValue1 = new System.Windows.Forms.TextBox();
            this.perValue2 = new System.Windows.Forms.TextBox();
            this.thValue1 = new System.Windows.Forms.TextBox();
            this.thValue2 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.leng.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.leng);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.groupBox4);
            this.flowLayoutPanel1.Controls.Add(this.groupBox5);
            this.flowLayoutPanel1.Controls.Add(this.groupBox6);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(898, 172);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // leng
            // 
            this.leng.Controls.Add(this.lengValue);
            this.leng.Location = new System.Drawing.Point(3, 3);
            this.leng.Name = "leng";
            this.leng.Size = new System.Drawing.Size(89, 42);
            this.leng.TabIndex = 1;
            this.leng.TabStop = false;
            this.leng.Text = "主干长度";
            // 
            // lengValue
            // 
            this.lengValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lengValue.Location = new System.Drawing.Point(3, 17);
            this.lengValue.Name = "lengValue";
            this.lengValue.Size = new System.Drawing.Size(83, 21);
            this.lengValue.TabIndex = 0;
            this.lengValue.Text = "100";
            this.lengValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nValue);
            this.groupBox1.Location = new System.Drawing.Point(98, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 42);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "递归深度";
            // 
            // nValue
            // 
            this.nValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nValue.Location = new System.Drawing.Point(3, 17);
            this.nValue.Name = "nValue";
            this.nValue.Size = new System.Drawing.Size(109, 21);
            this.nValue.TabIndex = 0;
            this.nValue.Text = "10";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.perValue1);
            this.groupBox2.Location = new System.Drawing.Point(219, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(97, 42);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "右分支长度比";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.perValue2);
            this.groupBox3.Location = new System.Drawing.Point(322, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(97, 42);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "左分支长度比";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.thValue1);
            this.groupBox4.Location = new System.Drawing.Point(425, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(104, 42);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "右分支角度";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.thValue2);
            this.groupBox5.Location = new System.Drawing.Point(535, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(108, 42);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "左分支角度";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButton4);
            this.groupBox6.Controls.Add(this.radioButton3);
            this.groupBox6.Controls.Add(this.radioButton2);
            this.groupBox6.Controls.Add(this.radioButton1);
            this.groupBox6.Location = new System.Drawing.Point(649, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(119, 84);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "画笔颜色";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(774, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "绘图";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 289);
            this.panel1.TabIndex = 1;
            // 
            // perValue1
            // 
            this.perValue1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.perValue1.Location = new System.Drawing.Point(3, 17);
            this.perValue1.Name = "perValue1";
            this.perValue1.Size = new System.Drawing.Size(91, 21);
            this.perValue1.TabIndex = 0;
            this.perValue1.Text = "0.6";
            // 
            // perValue2
            // 
            this.perValue2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.perValue2.Location = new System.Drawing.Point(3, 17);
            this.perValue2.Name = "perValue2";
            this.perValue2.Size = new System.Drawing.Size(91, 21);
            this.perValue2.TabIndex = 0;
            this.perValue2.Text = "0.7";
            // 
            // thValue1
            // 
            this.thValue1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thValue1.Location = new System.Drawing.Point(3, 17);
            this.thValue1.Name = "thValue1";
            this.thValue1.Size = new System.Drawing.Size(98, 21);
            this.thValue1.TabIndex = 0;
            this.thValue1.Text = "30";
            // 
            // thValue2
            // 
            this.thValue2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thValue2.Location = new System.Drawing.Point(3, 17);
            this.thValue2.Name = "thValue2";
            this.thValue2.Size = new System.Drawing.Size(102, 21);
            this.thValue2.TabIndex = 0;
            this.thValue2.Text = "20";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton1.Location = new System.Drawing.Point(3, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(113, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Blue";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton2.Location = new System.Drawing.Point(3, 33);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(113, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Yellow";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton3.Location = new System.Drawing.Point(3, 49);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(113, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Red";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton4.Location = new System.Drawing.Point(3, 65);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(113, 16);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Green";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.leng.ResumeLayout(false);
            this.leng.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox leng;
        private System.Windows.Forms.TextBox lengValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nValue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox perValue1;
        private System.Windows.Forms.TextBox perValue2;
        private System.Windows.Forms.TextBox thValue1;
        private System.Windows.Forms.TextBox thValue2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

