using System;
using Ninject.Modules;

namespace NinjectEventsExperiment
{
	public class Module2 : NinjectModule
	{
		public override void Load ()
		{
			Kernel.Bind<People2> ().ToSelf ().InSingletonScope ();
		}
	}
}

