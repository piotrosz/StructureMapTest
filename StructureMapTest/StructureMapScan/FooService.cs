namespace StructureMapScan
{
    public class FooService
    {
        private readonly IFoo foo;

        public FooService(IFoo foo)
        {
            this.foo = foo;
        }

        public void Bar()
        {
            this.foo.Bar();
        }
    }
}
