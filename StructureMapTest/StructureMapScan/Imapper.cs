namespace StructureMapScan
{
    public interface IMapper<in TIn, out TOut>
    {
        TOut Map(TIn item);
    }
}
