using System;
namespace MoshInterfaceExercise
{
	public interface IWorkflow
	{
		void Add(ITask task);
		void Remove(ITask task);
		IEnumerable<ITask> GetTasks();

    }
}

