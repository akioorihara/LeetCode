using System;
namespace MoshInterfaceExercise
{
	public class EmailNotifications : IWorkflow
	{
		public EmailNotifications()
		{
		}

		/// <summary>
		/// Execute to send email notifications
		/// </summary>
		public void Execute()
		{
			Console.WriteLine("Sending an email notification....");

		}
	}
}

