using System;
using Ninject;

namespace NinjectEventsExperiment
{
	public class AppBootstrapper
	{
		private readonly IKernel _kernel = new StandardKernel();

		public AppBootstrapper ()
		{
			Init ();
		}

		private void Init()
		{
			_kernel.Load<Module1>();
			_kernel.Load<Module2>();
		}

		public T Resolve<T>()
		{
			return this._kernel.Get<T>();
		}

		public T TryResolve<T>()
		{
			return this._kernel.CanResolve<T>() ? this._kernel.Get<T>() : default(T);
		}
	}
}

