using System;
using Ninject.Extensions.MessageBroker;

namespace NinjectEventsExperiment
{
	public class People1
	{
		public bool HasListeners
		{
			get { return ( MessageReceived != null ); }
		}

		[Publish( "message://People1/MessageReceived" )]
		public event EventHandler<MessageEventArgs> MessageReceived;

		public void SendMessage( string message )
		{
			EventHandler<MessageEventArgs> evt = MessageReceived;

			if ( evt != null )
			{
				evt( this, new MessageEventArgs( message ) );
			}
		}
	}
}

