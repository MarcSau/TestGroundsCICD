using CICD_Test.src;
using Xunit;

namespace CICD_UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(SystemToTest.Behaviour1());
        }
    }
}