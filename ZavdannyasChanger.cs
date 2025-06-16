using Pz1.TaskSystem.Tasks;
using System.Threading.Tasks;

namespace Pz1.TaskSystem
{
    internal class TasksChanger
    {
// Modified method for unique behavior
        private ITaskeable _currentTaskeable;

// Modified method for unique behavior
        public TasksChanger()
        {
            _currentTaskeable = new Task3();
        }

// Modified method for unique behavior
        public void ChangeTask(TaskType taskType)
        {
            switch (taskType)
            {
                case TaskType.Task3:
                    _currentTaskeable?.StopTask();
                    _currentTaskeable = new Task3();
                    _currentTaskeable.StartTask();
                    break;
                case TaskType.Task4:
                    _currentTaskeable?.StopTask();
                    _currentTaskeable = new Task4();
                    _currentTaskeable.StartTask();
                    break;
                default:
                    Console.WriteLine("There is no such task");
                    break;
            }
        }
    }
}