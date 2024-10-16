using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace DeveloperSample.Container
{
    internal interface IContainerTestInterface
    {
    }

    internal class ContainerTestClass : IContainerTestInterface
    {
    }

    public class ContainerTest
    {
        [Fact]
        public void CanBindAndGetService()
        {
            var container = new Container();
            container.Bind(typeof(IContainerTestInterface), typeof(ContainerTestClass));

            var testInstance = container.Get<IContainerTestInterface>();

            Assert.IsType<ContainerTestClass>(testInstance);
        }

        [Fact]
        public void IncorrectBindingThrowsException()
        {
            var container = new Container();
            
            Assert.Throws<InvalidCastException>(() => container.Bind(typeof(IList), typeof(ContainerTestClass)));
        }

        [Fact]
        public void GetUnboundTypeThrowsKeyNotFoundException()
        {
            var container = new Container();

            Assert.Throws<KeyNotFoundException>(container.Get<IContainerTestInterface>);
        }
    }
}