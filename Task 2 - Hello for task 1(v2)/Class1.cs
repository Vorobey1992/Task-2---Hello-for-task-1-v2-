namespace Task_2___Hello_for_task_1_v2_
{
    public class HelloMessage
    {
        public string? _name;
        public HelloMessage()
        {
            Console.WriteLine("Please enter your name:");
            string? name = Console.ReadLine();
            _name = name;
        }

        public void Print()
        { 
            Console.WriteLine($"Hello {_name}"); 
        }
    }
}