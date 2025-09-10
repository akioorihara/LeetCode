using System;
namespace MoshInterfaceExercise
{
	public class EmailNotifications : IWorkflow
	{
		private readonly string _sendTo;
		private readonly string _title;


		public EmailNotifications(Email email)
		{
			_sendTo = email.SendToAddress;
			_title = email.Title;
		}

		/// <summary>
		/// Execute to send email notifications
		/// </summary>
		public void Execute()
		{
			Console.WriteLine($"Sending an email notification " +
				$"to {_sendTo} and the subject of {_title}....");

		}
	}
}

