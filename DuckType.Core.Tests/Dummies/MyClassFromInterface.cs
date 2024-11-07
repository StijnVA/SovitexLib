﻿using DuckType.Core.Smart.Attributes;

namespace DuckType.Core.Tests.Dummies
{
    public class MyClassFromInterface : IMyClass
    {
        [SmartEmail] 
        public string EmailAddress { get; set; }
    }
}