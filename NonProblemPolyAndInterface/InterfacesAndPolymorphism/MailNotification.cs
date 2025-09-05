using System;
namespace InterfacesAndPolymorphism
{
    public class MailNotification : INortification
	{
		public MailNotification()
		{
        }

        public void Send(Message message)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Sending mails....");
        }
    }
}

