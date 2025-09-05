using System;
namespace InterfacesAndPolymorphism
{
	public class TextNotification: INortification
	{
		public TextNotification()
		{
		}

        public void Send(Message message)
        {
			//throw new NotImplementedException();
			Console.WriteLine("Sending Text Notification...");
		}
    }
}

