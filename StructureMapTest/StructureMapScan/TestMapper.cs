namespace StructureMapScan
{
    public class TestMapper : IMapper<int, string>
    {
        public string Map(int item)
        {
            return string.Format("Mapped value: {0}", item);
        }
    }
}
