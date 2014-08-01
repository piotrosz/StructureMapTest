namespace StructureMapConventions.Tests
{
    using Xunit;

    public class MyConventionTests
    {
        [Fact]
        public void gets_insert_command_handler()
        {
            var container = ApplicationConfiguration.Init();

            var resultA = container.GetInstance<ICommandHandler<ClassA>>();
            var resultB = container.GetInstance<ICommandHandler<ClassB>>();
            var resultC = container.GetInstance<ICommandHandler<ClassC>>();
            var resultD = container.GetInstance<ICommandHandler<ClassD>>();

            Assert.True(resultA.GetType() == typeof(InsertCommandHandler<ClassA>));
            Assert.True(resultB.GetType() == typeof(InsertCommandHandler<ClassB>));
            Assert.True(resultC.GetType() == typeof(InsertCommandHandler<ClassC>));
            Assert.True(resultD.GetType() == typeof(InsertCommandHandler<ClassD>));
        }
    }
}
