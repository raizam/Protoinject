﻿using System;

namespace Protoinject
{
    public class DefaultMapping : IMapping
    {
        internal DefaultMapping()
        {
        }

        public DefaultMapping(
            Type target,
            Func<IContext, object> targetMethod,
            bool targetFactory,
            INode onlyUnderDescendantFilter,
            IScope lifetimeScope,
            bool uniquePerScope,
            string named)
        {
            Target = target;
            TargetMethod = targetMethod;
            TargetFactory = targetFactory;
            OnlyUnderDescendantFilter = onlyUnderDescendantFilter;
            LifetimeScope = lifetimeScope;
            UniquePerScope = uniquePerScope;
            Named = named;
        }

        public Type Target { get; internal set; }
        public Func<IContext, object> TargetMethod { get; internal set; } 
        public INode OnlyUnderDescendantFilter { get; internal set; }
        public IScope LifetimeScope { get; internal set; }
        public bool UniquePerScope { get; internal set; }
        public string Named { get; internal set; }
        public bool Valid => true;
        public bool TargetFactory { get; internal set; }
    }
}
