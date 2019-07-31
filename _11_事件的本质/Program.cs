using System;
using System.Threading;

namespace _11_事件的本质
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayMusic playMusic = new PlayMusic("忐忑");

            playMusic.DelPlayMusic += PlayMusic_DelPlayMusic;   // 添加注册事件
            playMusic.PlaySongs();
            Console.ReadKey();
        }

        /// <summary>
        /// 音乐播放完成，要执行的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void PlayMusic_DelPlayMusic(object sender, EventArgs e)
        {
            Console.WriteLine("播放完成！");
        }
    }


    class PlayMusic
    {
        public event EventHandler DelPlayMusic;

        public string Name { set; get; }
        public PlayMusic(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// 调用方法，播放音乐，执行事件
        /// </summary>
        public void PlaySongs()
        {
            Console.WriteLine("正在播放" + this.Name);
            // 等待模拟播放3秒钟
            Thread.Sleep(3000);

            // 播放完成后，执行事件，执行事件对象是本身，事件资源e，直接new出即可
            if (DelPlayMusic != null)
            {
                DelPlayMusic(this,new EventArgs());
            }
        }

    }
}
