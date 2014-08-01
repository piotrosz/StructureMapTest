namespace HelloStructureMap
{
    public class AppEngine : IAppEngine
    {
        private readonly IGreeter greeter;
        private readonly IOutputDisplay outputDisplay;

        public AppEngine(IGreeter greeter, IOutputDisplay outputDisplay)
        {
            this.greeter = greeter;
            this.outputDisplay = outputDisplay;
        }

        public void Run()
        {
            this.outputDisplay.Show(this.greeter.GetGreeting());
        }
    }
}
