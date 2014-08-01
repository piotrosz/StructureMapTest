namespace HelloStructureMap
{
    using System;

    public class ConsoleOutputDisplay : IOutputDisplay
    {
        public void Show(string message)
        {
            Console.WriteLine(message);
        }
    }
}
