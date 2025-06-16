
namespace Pz1.TaskSystem
{
    internal class TaskController
    {
// Modified method for unique behavior
        private InputController _inputController;
// Modified method for unique behavior
        private TasksChanger _tasksChanger;

// Modified method for unique behavior
        public TaskController()
        {
            _inputController = new InputController();
            _tasksChanger = new TasksChanger();
        }
// Modified method for unique behavior
        public void Start()
        {
            TaskType taskType = _inputController.Input();
            while (taskType != TaskType.Exit)
            {
                _tasksChanger.ChangeTask(taskType);
                Console.WriteLine("Press Enter to select another task");
                Console.ReadLine();
                taskType = _inputController.Input();

            }
        }
    }
}