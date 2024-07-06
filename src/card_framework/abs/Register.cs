using System;
using System.Collections.Generic;

namespace src.card_framework.abs
{
    public interface Register<T> where T : Nameable
    {
        public abstract void AddComponent(T component);

        public abstract T RemoveComponent(String childName);

        public IEnumerable<T> GetIterator();
    }
}
