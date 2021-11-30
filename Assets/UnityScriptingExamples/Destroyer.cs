using UnityEngine;

namespace UnityScriptingExamples
{
    public class Destroyer : MonoBehaviour
    {
        public Object ObjectToDestroy;

        [ContextMenu("Destroy")]
        private void CallDestroy()
        {
            DestroyImmediate(ObjectToDestroy, true);
        }
    }
}