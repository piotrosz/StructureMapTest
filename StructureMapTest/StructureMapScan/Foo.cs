namespace StructureMapScan
{
    using System;

    public class Foo : IFoo
    {
        public void Bar()
        {
            Console.WriteLine("I am Foo");
        }
    }

    public class Foo1 : IFoo
    {
        public void Bar()
        {
            Console.WriteLine("I am Foo1");
        }
    }
}
