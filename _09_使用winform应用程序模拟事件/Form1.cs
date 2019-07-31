using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_使用winform应用程序模拟事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PlayMusic p = new PlayMusic("忐忑");   // 创建音乐播放对象

            p.del += Test;   // 注册事件
            p.PlaySongs();   // 播放音乐
        }

        // 事件要执行事件
        void Test()
        {
            MessageBox.Show("播放完成了");
        }
    }
}
