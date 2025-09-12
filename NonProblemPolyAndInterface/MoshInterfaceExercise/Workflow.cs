using System;
namespace MoshInterfaceExercise
{
	public class Workflow : IWorkflow
	{
        private readonly IList<ITask> _tasks;

		public Workflow()
		{
            _tasks = new List<ITask>();
		}

        public void Add(ITask task)
        {
            _tasks.Add(task);
            //throw new NotImplementedException();
        }

        public void Remove(ITask task)
        {
            _tasks.Remove(task);
        }

        /// <summary>
        /// The reason why we use IEnumerable over List<> is that
        /// Add and Remove class should be the only methods to interface
        /// with private object - IEnumerable is a readonly of List
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ITask> GetTasks()
        {
            return _tasks;
        }
    }
}

