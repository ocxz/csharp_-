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
    // 声明一个委托，用来接收Form1传过来的函数
    public delegate void DelSetValue(string str);

    public partial class Form2 : Form
    {
        private DelSetValue _del;  // 声明一个委托变量，用来存储接收过来的委托函数
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(DelSetValue del) : this()
        {
            this._del = del;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _del(textBox1.Text.Trim());
        }
    }
}
