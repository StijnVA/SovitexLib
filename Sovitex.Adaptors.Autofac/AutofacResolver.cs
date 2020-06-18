﻿using System;
using Autofac;
using SovitexLib.Internals;

namespace Sovitex.Adaptors.Autofac
{
    public class AutofacResolver : IResolver
    {
        private readonly ILifetimeScope _lifetimeScope;

        public AutofacResolver(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
        }
        public T Resolve<T>()
        {
            return _lifetimeScope.Resolve<T>();
        }

        public object Resolve(Type type)
        {
            return _lifetimeScope.Resolve(type);
        }
    }
}