namespace StructureMapScan
{
    using System;

    public class TestMapperDecorator : IMapper<int, string>
    {
        private readonly IMapper<int, string> mapper; 

        public TestMapperDecorator(IMapper<int, string> mapper)
        {
            this.mapper = mapper;
        }

        public string Map(int item)
        {
            Console.WriteLine("I am mapper decorator");
            return this.mapper.Map(item);
        }
    }
}
