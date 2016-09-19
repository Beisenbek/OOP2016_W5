using System;
namespace ObjectCollistion
{
	public class SuperSharp
	{
		private char sign;
		private int x;
		private int y;
		private int dx;
		private int dy;

		public void Redraw()
		{
			ChangePosition();
			Console.SetCursorPosition(x, y);
			Console.WriteLine(sign);
		}

		void ChangePosition()
		{
			x = x + dx;
			y = y + dy;


			if (x + dx >= Global.screenWidth)
			{
				dx = -1;
			}

			if (x + dx <= 0)
			{
				dx = 1;
			}


			if (y + dy >= Global.screenHeight)
			{
				dy = -1;
			}

			if (y + dy <= 0)
			{
				dy = 1;
			}



		}

		public SuperSharp(char sign, int x, int y)
		{
			this.sign = sign;
			this.x = x;
			this.y = y;
			dx = 1;
			dy = 1;
		}
	}
}

