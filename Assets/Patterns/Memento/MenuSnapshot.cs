using System;

namespace Patterns.Memento
{
    public class MenuSnapshot : AbstractSnapshot
    {
        public MenuSnapshot(Action doFun, ISnapshotable menu)
        {
            Do = doFun;
            Undo = menu.GetCurrentStateApplyingFunction();
        }
    }
}