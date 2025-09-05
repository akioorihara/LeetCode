using System;
namespace InterfacesAndPolymorphism
{
	public class VideoEncode
	{
		//private readonly MailService _mailService;

		private readonly IList<INotification> notifications;


		public VideoEncode()
		{
			//_mailService = new MailService();
		}

		public void Encode(Video video)
		{
			//_mailService.Send(new Mail());
		}
	}
}

