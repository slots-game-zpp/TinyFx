﻿namespace Nacos.Naming.Dtos
{
    public abstract class AbstractSelector
    {
        public string Type { get; private set; }

        public AbstractSelector(string type) => Type = type;
    }
}
