using System;
using SimplePackage;
using Xunit;

namespace SimplePackageTests
{
    public class TrainsTests
    {
        [Fact]
        public void Trains_Should_Be_Awesome()
        {
            var t = new Trains();
            Assert.True(t.AreTrainsAwesome);
        }
    }
}
