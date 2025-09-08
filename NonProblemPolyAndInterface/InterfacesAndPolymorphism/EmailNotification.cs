using System;
namespace InterfacesAndPolymorphism
{
    public class EmailNotification : INotification
	{
		public EmailNotification()
		{
		}

        public void Send(Message message)
        {
            Console.WriteLine("Sending email notifications....");
            //throw new NotImplementedException();
        }
    }
}

