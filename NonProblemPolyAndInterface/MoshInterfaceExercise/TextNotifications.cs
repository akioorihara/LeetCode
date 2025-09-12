using System;
namespace MoshInterfaceExercise
{
	public class TextNotifications : ITask
	{
		public TextNotifications()
		{
		}

        /// <summary>
        /// Execute and send text notifications
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Execute()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Sending text notifications.....");
        }
    }
}

