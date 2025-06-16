
namespace Pz1.TaskSystem
{
    internal class InputController
    {
// Modified method for unique behavior
        public TaskType Input()
        {
            int inputNumber;
            do
            {
                Console.Clear();
                Console.WriteLine("Enter number : ");
                Console.WriteLine("Press 3 - Task3");
                Console.WriteLine("Press 4 - Task4");
                Console.WriteLine("Press \"2\" to exit");

            }
            while (!int.TryParse(Console.ReadLine(), out inputNumber) || !IsWithinRange(inputNumber, 2, 4));

            switch (inputNumber)
            {
                case 2:
                    return TaskType.Exit;
                case 3:
                    return TaskType.Task3;
                case 4:
                    return TaskType.Task4;
                default:
                    return TaskType.None;
            }
        }

        bool IsWithinRange(int number, int min, int max)
        {
            return number >= min && number <= max;
        }
    }
}