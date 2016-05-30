using System;
using Ninject.Modules;

namespace NinjectEventsExperiment
{
	public class Module1 : NinjectModule
	{
		public override void Load ()
		{
			Kernel.Bind<People1> ().ToSelf ().InSingletonScope ();
		}
	}
}

