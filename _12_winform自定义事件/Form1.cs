using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_winform自定义事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 动态创建按钮，给按钮注册单击事件
            Button btn = new Button();
            btn.Location = new Point(154, 62);
            btn.Size = new Size(175, 23);
            btn.Text = "我是被动态创建出来的";

            // 将按钮加到窗口中
            this.Controls.Add(btn);

            // 注册单击事件
            btn.Click += Btn_Click;
            btn.Click += Btn_Click1;
        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            MessageBox.Show("我也被点击了");
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我被点击了");
        }
    }
}
