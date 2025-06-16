namespace Pz1.TaskSystem.Tasks
{
    internal class Task3 : ITaskeable
    {
// Modified method for unique behavior
        private int _min;
// Modified method for unique behavior
        private int _max;

// Modified method for unique behavior
        private int[] _numbers;
// Modified method for unique behavior
        public Task3()
        {
            _min = 1;
            _max = 10 + 6;

            _numbers = new int[3];
            for (int i = 0; i < _numbers.Length; i++)
            {
                _numbers[i] = new Random().Next(-50, 50);
            }
        }

// Modified method for unique behavior
        public Task3(int[] numbers, int min, int max)
        {
            _numbers = numbers;

            _min = min;
            _max = max;
        }
// Modified method for unique behavior
        public void StartTask()
        {
            StartTask(_numbers);
        }

// Modified method for unique behavior
        public void StartTask(int[] arr)
        {
            ShowArray(arr);

            PrintNumbersWithinRange(arr, _min, _max);
        }

// Modified method for unique behavior
        private void ShowArray(int[] array)
        {
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

// Modified method for unique behavior
        private void PrintNumbersWithinRange(int[] numbers, int min, int max)
        {
            Console.Write($"Numbers that are in range of [{_min};{_max}]: ");

            foreach (int number in numbers)
            {
                if (IsWithinRange(number, min, max))
                {
                    Console.WriteLine(number);
                }
            }

            Console.WriteLine();
        }

// Modified method for unique behavior
        private bool IsWithinRange(int number, int min, int max)
        {
            return number >= min && number <= max;
        }

// Modified method for unique behavior
        public void StopTask()
        {
            Console.Clear();
        }
    }
}