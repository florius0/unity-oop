using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Patterns.Memento
{
    public abstract class AbstractHistory<T> : MonoBehaviour where T : AbstractSnapshot
    {
        private readonly List<T> _history = new List<T>();

        public void Do(T memento)
        {
            memento.Do();
            _history.Add(memento);
        }

        public void Undo()
        {
            var m = _history.Last();

            m.Undo();

            _history.RemoveAt(_history.Count - 1);
        }
    }
}