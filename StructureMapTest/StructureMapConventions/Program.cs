namespace StructureMapConventions
{
    using System;

    using StructureMap;
    using StructureMap.Graph;

    class Program
    {
        static void Main(string[] args)
        {
            ApplicationConfiguration.Init();
        }
    }

    public static class ApplicationConfiguration
    {
        public static Container Init()
        {
            return new Container(x => x.Scan(
                y =>
                {
                    y.TheCallingAssembly();
                    y.Convention<MyConvention>();
                    //y.LookForRegistries();
                }));
        }
    }

    public abstract class BaseEntity { }
    public interface ICommandHandler<T> { }
    public class ClassA : BaseEntity { }
    public class ClassB : BaseEntity { }
    public class ClassC : BaseEntity { }
    public class ClassD : BaseEntity { }
    public class InsertCommandHandler<T> : ICommandHandler<T> { }
    public class SpecialInsertDCommandHandler : ICommandHandler<ClassD> { }
}
