
namespace 成绩模块_数组_
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
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_max = new System.Windows.Forms.Label();
            this.lb_min = new System.Windows.Forms.Label();
            this.lb_average = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(51, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "成绩显示";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(173, 107);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(409, 152);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 15F);
            this.button1.Location = new System.Drawing.Point(56, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 15F);
            this.button2.Location = new System.Drawing.Point(56, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "清空";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(274, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "最高分：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(274, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "最低分：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(274, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "平均分：";
            // 
            // lb_max
            // 
            this.lb_max.AutoSize = true;
            this.lb_max.Font = new System.Drawing.Font("宋体", 15F);
            this.lb_max.Location = new System.Drawing.Point(376, 330);
            this.lb_max.Name = "lb_max";
            this.lb_max.Size = new System.Drawing.Size(137, 25);
            this.lb_max.TabIndex = 4;
            this.lb_max.Text = "显示最高分";
            // 
            // lb_min
            // 
            this.lb_min.AutoSize = true;
            this.lb_min.Font = new System.Drawing.Font("宋体", 15F);
            this.lb_min.Location = new System.Drawing.Point(376, 355);
            this.lb_min.Name = "lb_min";
            this.lb_min.Size = new System.Drawing.Size(137, 25);
            this.lb_min.TabIndex = 4;
            this.lb_min.Text = "显示最低分";
            // 
            // lb_average
            // 
            this.lb_average.AutoSize = true;
            this.lb_average.Font = new System.Drawing.Font("宋体", 15F);
            this.lb_average.Location = new System.Drawing.Point(376, 380);
            this.lb_average.Name = "lb_average";
            this.lb_average.Size = new System.Drawing.Size(137, 25);
            this.lb_average.TabIndex = 4;
            this.lb_average.Text = "显示平均分";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(409, 25);
            this.textBox1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F);
            this.label5.Location = new System.Drawing.Point(51, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "成绩输入";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 572);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_average);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_min);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_max);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_max;
        private System.Windows.Forms.Label lb_min;
        private System.Windows.Forms.Label lb_average;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

