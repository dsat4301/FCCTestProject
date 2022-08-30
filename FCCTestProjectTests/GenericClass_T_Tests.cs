using Xunit;

namespace TestProject.Tests
{
    public class GenericClass_T_Tests
    {
        [Fact]
        public void CoveredMethodTest()
        {
            GenericClass<int> sut = new();

            sut.CoveredMethod();
        }
    }
}