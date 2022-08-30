using Xunit;

namespace TestProject.Tests
{
    public class NonGenericClassTests
    {
        [Fact]
        public void CoveredMethodTest()
        {
            NonGenericClass sut = new();

            sut.CoveredMethod();
        }
    }
}