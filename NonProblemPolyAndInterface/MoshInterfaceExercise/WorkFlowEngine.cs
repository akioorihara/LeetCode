using System;
namespace MoshInterfaceExercise
{
	public class WorkFlowEngine
	{
        /// <summary>
        /// Process and execute all workflow(s)
        /// </summary>
        public void Run(IWorkflow workflows)
		{
			foreach(ITask item in workflows.GetTasks())
			{
				try
				{
                    //execute each worklow
                    item.Execute();
                }
				catch(Exception ex)
				{
					Console.WriteLine(ex.Message);
					throw;
				} 
				
			}
		}

		
	}
}

