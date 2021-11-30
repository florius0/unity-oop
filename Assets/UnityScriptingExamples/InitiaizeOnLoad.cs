using UnityEngine;

namespace UnityScriptingExamples
{
    public class InitiaizeOnLoad
    {
        [RuntimeInitializeOnLoadMethod]
        public static void OnLoad()
        {
            Debug.Log("RuntimeInitializeOnLoadMethod is called");
        }
    }
}