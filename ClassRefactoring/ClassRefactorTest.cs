using System;
using Xunit;

namespace DeveloperSample.ClassRefactoring
{
    public class ClassRefactorTest
    {
        [Fact]
        public void AfricanSwallowHasCorrectSpeed()
        {
            var swallowFactory = new SwallowFactory();
            var swallow = swallowFactory.GetSwallow(SwallowType.African);

            Assert.Equal(22, swallow.GetAirspeedVelocity());
        }

        [Fact]
        public void LadenAfricanSwallowHasCorrectSpeed()
        {
            var swallowFactory = new SwallowFactory();
            var swallow = swallowFactory.GetSwallow(SwallowType.African);

            swallow.ApplyLoad(SwallowLoad.Coconut);

            Assert.Equal(18, swallow.GetAirspeedVelocity());
        }

        [Fact]
        public void EuropeanSwallowHasCorrectSpeed()
        {
            var swallowFactory = new SwallowFactory();
            var swallow = swallowFactory.GetSwallow(SwallowType.European);

            Assert.Equal(20, swallow.GetAirspeedVelocity());
        }

        [Fact]
        public void LadenEuropeanSwallowHasCorrectSpeed()
        {
            var swallowFactory = new SwallowFactory();
            var swallow = swallowFactory.GetSwallow(SwallowType.European);

            swallow.ApplyLoad(SwallowLoad.Coconut);

            Assert.Equal(16, swallow.GetAirspeedVelocity());
        }

        [Fact]
        public void InvalidSwallowThrowsException()
        {
            var swallowFactory = new SwallowFactory();

            Assert.Throws<InvalidOperationException>(() => swallowFactory.GetSwallow((SwallowType)(-1)));
        }

        [Fact]
        public void SwallowLadenWithInvalidLoadThrowsException()
        {
            var swallowFactory = new SwallowFactory();
            var swallow = swallowFactory.GetSwallow(SwallowType.European);

            swallow.ApplyLoad((SwallowLoad)(-1));

            Assert.Throws<InvalidOperationException>(() => swallow.GetAirspeedVelocity());
        }
    }
}