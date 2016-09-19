using System;
using System.Collections.Generic;
using System.Threading;

namespace ObjectCollistion
{
	public class Scene
	{
		List<SuperSharp> ss = new List<SuperSharp>();

		public Scene()
		{
		}

		public void Run()
		{
			bool ok = true;

			ThreadStart t = new ThreadStart(() =>
			{
				while (ok)
				{
					ChangeScene();
					Thread.Sleep(Global.speed);
				}
			});

			t.Invoke();
		}

		private void ChangeScene()
		{
			Console.Clear();

			foreach (SuperSharp s in ss)
			{
				s.Redraw();
			}
		}
			
		public void Setup()
		{
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.CursorVisible = false;

			for (int i = 0; i < 1; ++i)
			{
				ss.Add(new SuperSharp('*', i * 2, i * 3));
			}
		}
	}
}

