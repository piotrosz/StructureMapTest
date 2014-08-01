namespace StructureMapScan
{
    public class TestMapperService : ITestMapperService
    {
        private readonly IMapper<int, string> mapper;

        public TestMapperService(IMapper<int, string> mapper)
        {
            this.mapper = mapper;
        }

        public string Foo()
        {
            return mapper.Map(666);
        }
    }

    public interface ITestMapperService
    {
        string Foo();
    }
}
