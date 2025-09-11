using System;
namespace MoshInterfaceExercise
{
	public class CallWebService : IWorkflow
	{
		public CallWebService()
		{
		}

        public void Execute()
        {

			Console.WriteLine("Calling the web servcie.......");
        }
    }
}

