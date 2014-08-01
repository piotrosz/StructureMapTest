namespace StructureMapScan
{
    using System.Collections.Generic;
    using System.Diagnostics;

    using StructureMap;
    using StructureMap.Graph;

    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container(
                c =>
                    {
                        c.Scan(
                            scanner =>
                                {
                                    scanner.TheCallingAssembly();
                                    scanner.WithDefaultConventions();
                                    scanner.ConnectImplementationsToTypesClosing(typeof(IMapper<,>));
                                });

                        c.For<IMapper<int, string>>().Use<TestMapper>().DecorateWith(x => new TestMapperDecorator(x));

                        //c.For<IFoo>().Use<Foo1>();
                    });

            //var fooService = container.GetInstance<FooService>();
            //fooService.Bar();

            //IEnumerable<IFoo> fooInstances = container.GetAllInstances<IFoo>();
            //var fooInstance = container.TryGetInstance<IFoo>();
            //Debug.Assert(fooInstance != null, string.Format("No default instance of {0}", typeof(IFoo).FullName));

            // This will get the decorator
            var mapper = container.GetInstance<IMapper<int, string>>();
            var mappedValue = mapper.Map(100);

            // This will also get the decorator!!!
            var mapperService = container.GetInstance<ITestMapperService>();
            var value = mapperService.Foo();
        }
    }
}
