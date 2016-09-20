using System;
using System.Collections.Generic;
using System.Threading;

namespace ObjectCollistion
{
	public class Scene:IObserver
	{
        char[] signs = { '$', '#', '@', '%', '&' };

		List<SuperSharp> ss = new List<SuperSharp>();

		public Scene()
		{
		}

		public void Run()
		{
            Thread t = new Thread(new ThreadStart(Iteration));
            //t.IsBackground = false;
            t.Start();
		}


        private void Iteration()
        {
            while (true)
            {
                ChangeScene();
                Thread.Sleep(Global.speed);
            }
        }

		private void ChangeScene()
		{
			Console.Clear();

            lock (ss)
            {
                foreach (SuperSharp s in ss)
                {
                    s.Redraw();
                }
            }
		}

        public void Setup()
        {
            Console.SetWindowSize(50, 30);
            Console.SetBufferSize(50, 30);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorVisible = false;

            lock (ss)
            {
                ss.Add(new SuperSharp('*', 2, 3, 1, 1));
            }
        }

        public void AddNewItem()
        {
            lock (ss)
            {
                SuperSharp oldS = ss[ss.Count - 1];
                int yy = oldS.Y;
                int xx = oldS.X;
                int dx =-oldS.Dx;
                int dy = oldS.Dy;

                char c = signs[new Random().Next(0, signs.Length - 1)];

                SuperSharp newS = new SuperSharp(c, xx, yy, dx, dy);

                ss.Add(newS);
            }
        }

        public void Update()
        {
            foreach (SuperSharp s in ss)
            {
                s.Color = ConsoleColor.Red;
            }
        }
    }
}

