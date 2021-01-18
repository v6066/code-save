using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 成绩模块_数组_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //成绩统计模块
            //定义变量
            int[] scores = new int[] { 90,60,78,80,65,88};
            int max,min,sum,average;
            //数据初始化
            sum=min = max = scores[0];
            for (int i = 1; i <= scores.Length - 1; i++)
            {
                if (scores[i] > max)
                {
                    max = scores[i];
                }
                if (scores[i] < min)
                {
                    min = scores[i];
                }

                sum += scores[i];
            }
            average = sum / scores.Length;
            
            this.lb_max.Text = max.ToString();
            this.lb_min.Text = min.ToString();
            this.lb_average.Text = average.ToString();
            foreach(int sc in scores)
            {
                this.richTextBox1.Text += sc + " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //清空模块
            this.lb_average.Text = this.lb_max.Text = this.lb_min.Text = this.richTextBox1.Text = " ";
            }
    }
}
