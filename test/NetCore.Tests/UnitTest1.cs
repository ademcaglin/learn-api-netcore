using System;
using Xunit;
using Moq;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var x = new Mock<UnitTest1>();
            Assert.Equal(2+2, 4);
        }
    }
}
