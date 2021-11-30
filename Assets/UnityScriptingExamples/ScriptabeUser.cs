using System;
using UnityEngine;

namespace UnityScriptingExamples
{
    public class ScriptabeUser : MonoBehaviour
    {
        public SimpleScriptableObject ScriptableObject;

        private void OnValidate()
        {
            Debug.Log($"ScriptableObject.name = {ScriptableObject.name}");
            // ScriptableObject.
        }
    }
}