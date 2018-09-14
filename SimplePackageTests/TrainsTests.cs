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

        [Fact]
        public void Planes_Should_Be_Awesome()
        {
            var t = new Trains();
            Assert.True(t.ArePlanesAwesome);
        }

        [Fact]
        public void Automobiles_Should_Be_Awesome()
        {
            var t = new Trains();
            Assert.True(t.AreAutomobilesAwesome);
        }
    }
}
