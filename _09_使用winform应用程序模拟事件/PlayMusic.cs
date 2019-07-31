using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _09_使用winform应用程序模拟事件
{
    // 注册委托
    public delegate void DelPlayOver();
    class PlayMusic
    {
        //// 注册事件 声明事件不需要写小括号
        //public event DelPlayOver Del;
        public DelPlayOver del;

        public string Name { set; get; }

        public PlayMusic(string name)
        {
            this.Name = name;
        }

        public void PlaySongs()
        {
            Console.WriteLine("正在播放" + this.Name);
            Thread.Sleep(3000);   // 模拟播放3秒钟

            // 播放完成后，执行一个事件
            if (del != null)
            {
                del();  // 直接调用 ”事件“
            }
        }
    }
}
