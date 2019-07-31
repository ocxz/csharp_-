using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CaFacotry2;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载时，初始化好按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            // 109, 164  75 23
            string[] btnStr = File.ReadAllLines("config.txt");
            int x = 109;
            int y = 164;
            foreach (string item in btnStr)
            {
                Button btn = new Button();
                btn.Location = new Point(x, y);
                btn.Size = new Size(75, 23);
                btn.Text = item.Trim();
                btn.Click += Btn_Click;
                this.Controls.Add(btn);
                x += 80;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
