using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_使用委托进行窗体间传值
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        
        /// <summary>
        /// 声明一个方法，用来给label2赋值
        /// </summary>
        /// <param name="str">要赋值的字符串</param>
        private void SetText(string str)
        {
            label2.Text = str;
        }

        /// <summary>
        /// 点击按钮，显示Form2，将Form1中的赋值方法，传到Form2中进行赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            // 通过构造方法，将SetText函数，床给Fomr2
            Form2 form2 = new Form2(SetText);   // 通过构造方法，将SetText函数，床给Fomr2
            form2.Show();
        }
    }
}
