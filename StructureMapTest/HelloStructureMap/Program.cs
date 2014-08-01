namespace HelloStructureMap
{
    using StructureMap;

    class Program
    {
        static void Main(string[] args)
        {
            IContainer container = ConfigureDependencies();

            var appEngine = container.GetInstance<IAppEngine>();

            appEngine.Run();
        }

        static IContainer ConfigureDependencies()
        {
            return new Container(c => c.AddRegistry<HelloRegistry>());

            //return new Container(
            //    x =>
            //        {
            //            x.For<IAppEngine>().Use<AppEngine>();
            //            x.For<IGreeter>().Use<EnglishGreeter>();
            //            x.For<IOutputDisplay>().Use<ConsoleOutputDisplay>();
            //        });
        }
    }
}

