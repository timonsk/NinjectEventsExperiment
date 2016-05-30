using System;

namespace NinjectEventsExperiment
{
	public class MessageEventArgs
	{
		public MessageEventArgs( string message )
		{
			Message = message;
		}

		public string Message { get; set; }
	}
}

