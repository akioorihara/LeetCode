using System;
namespace InterfacesAndPolymorphism
{
	public class VideoEncode
	{
        //private readonly MailService _mailService;

        //This has to be IList as interface and not List as
        //List would be hard wire and cannot be hard coded as
        // _notifications = new List<INotification>();
        private readonly IList<INotification> _notifications;


		public VideoEncode()
		{
			//_mailService = new MailService();
			_notifications = new List<INotification>();
		}

		public void Encode(Video video)
		{
			//_mailService.Send(new Mail());
			foreach(var channel in _notifications)
			{
				channel.Send(new Message());
			}
		}

		public void Register(INotification channel)
		{
			_notifications.Add(channel);
		}

	}
}

