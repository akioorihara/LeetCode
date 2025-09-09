using System;
namespace MoshInterfaceExercise
{
	public class Email
	{
		private string _sendToAddress;
		private string _title; 

		//public string SendToAddress { get; set; }
		//public string Title { get; set; }

		public Email(string SendTo, string Title)
		{
			_sendToAddress = SendTo;
			_title = Title;
		}

	}
}

