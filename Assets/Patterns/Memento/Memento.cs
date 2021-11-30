using System;

namespace Patterns.Memento
{
    public abstract class AbstractSnapshot
    {
        public Action Do;

        public Action Undo;
    }
}