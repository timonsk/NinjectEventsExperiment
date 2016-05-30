using System;
using Ninject.Extensions.MessageBroker;

namespace NinjectEventsExperiment
{
	public class People2
	{
		public string LastMessage { get; set; }

		[Subscribe( "message://People1/MessageReceived" )]
		public void OnMessageReceived( object sender, MessageEventArgs args )
		{
			LastMessage = args.Message;
			Console.WriteLine (string.Format("Get message: {0} ", LastMessage));
		}
	}
}

