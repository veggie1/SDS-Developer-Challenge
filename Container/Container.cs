using System;
using System.Collections.Generic;

namespace DeveloperSample.Container
{
    public class Container
    {
        private readonly Dictionary<Type, Type> _bindings = new();

        public void Bind(Type interfaceType, Type implementationType)
        {
            var canAssign = interfaceType.IsAssignableFrom(implementationType);

            if (!canAssign)
            {
                throw new InvalidCastException($"{interfaceType} is not assignable to {implementationType}");
            }

            _bindings.Add(interfaceType, implementationType);
        }

        public T Get<T>()
        {
            if (!_bindings.ContainsKey(typeof(T)))
            {
                throw new KeyNotFoundException($"Key {typeof(T)} was not found");
            }

            var type = _bindings[typeof(T)];

            return (T)Activator.CreateInstance(type);
        }
    }
}