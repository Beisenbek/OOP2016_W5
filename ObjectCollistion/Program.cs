using System;
using System.Threading;

namespace ObjectCollistion
{
	class MainClass
	{

		public static void Main(string[] args)
		{
			Scene scene = new Scene();
			scene.Setup();
			scene.Run();

            Action action = new Action();
            action.Attach(scene);

            action.Run(scene);
		}

	}
}
   