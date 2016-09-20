using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCollistion
{
    public class Action:Subject
    {
        public void Run(Scene s)
        {
            while (true)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                switch (pressedKey.Key)
                {
                    case ConsoleKey.Enter:
                        Notify();
                        break;
                    case ConsoleKey.Spacebar:
                        s.AddNewItem();
                        break;
                }
            }
        }

    }
}
