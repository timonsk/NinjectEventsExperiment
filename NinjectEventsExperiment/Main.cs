using System;

namespace NinjectEventsExperiment
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Initialize IoC");
			var boot = new AppBootstrapper ();
			var p1 = boot.Resolve<People1>();
			var p2 = boot.Resolve<People2>();
			p1.SendMessage ("Hello from: p1");

			Console.ReadKey ();

		}
	}
}
