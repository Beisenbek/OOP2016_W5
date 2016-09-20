using System;
namespace ObjectCollistion
{
    public class SuperSharp
    {
        public ConsoleColor Color { get; set; }
        private char sign;
        private int x;
        private int y;
        private int dx;
        private int dy;

        public int X { get { return x; } }
        public int Y { get { return y; } }

        public int Dx { get { return dx; } }
        public int Dy { get { return dy; } }

        public void Redraw()
        {
            ChangePosition();
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(x, y);
            Console.Write(sign);
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

        public SuperSharp(char sign, int x, int y, int dx, int dy)
        {
            this.sign = sign;
            this.x = x;
            this.y = y;
            this.dx = dx;
            this.dy = dy;
            Color = ConsoleColor.White;
        }
    }
}

