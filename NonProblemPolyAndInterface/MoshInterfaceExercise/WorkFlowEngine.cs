using System;
namespace MoshInterfaceExercise
{
	public class WorkFlowEngine
	{
		//private readonly IWorkflow _workflow;
		private readonly IList<IWorkflow> _workflows;

		/// <summary>
		/// Constractor taking a list of workflow interfaces 
		/// </summary>
		/// <param name="workflows">A list of workflow interfaces</param>
		//public WorkFlowEngine(List<IWorkflow> workflows)

        public WorkFlowEngine()
        {
			_workflows = new List<IWorkflow>();
		}


        /// <summary>
        /// Process and execute all workflow(s)
        /// </summary>
        public void Run()
		{
			foreach(var workflow in _workflows)
			{
				//execute each worklow
				workflow.Execute();
			}
		}

		/// <summary>
		/// Register workflow(s) to the list 
		/// </summary>
		public void Register(IWorkflow workflow)
		{
			_workflows.Add(workflow);
		}
		
	}
}

