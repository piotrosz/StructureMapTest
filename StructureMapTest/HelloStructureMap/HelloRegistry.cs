namespace HelloStructureMap
{
    using StructureMap.Configuration.DSL;

    public class HelloRegistry : Registry
    {
        public HelloRegistry()
        {
            For<IAppEngine>().Use<AppEngine>();
            For<IGreeter>().Use<EnglishGreeter>();
            For<IOutputDisplay>().Use<ConsoleOutputDisplay>();
        }
    }
}
