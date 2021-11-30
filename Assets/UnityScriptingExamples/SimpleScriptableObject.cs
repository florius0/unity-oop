using System.Collections.Generic;
using UnityEngine;

namespace UnityScriptingExamples
{
    [CreateAssetMenu(fileName = "Simple ScriptableObject", menuName = "UnityScripting/Simple ScriptableObject", order = 0)]
    public class SimpleScriptableObject : ScriptableObject
    {
        [Header("Simple types")]
        [Tooltip("Tooltip is shown on mouse hover")]
        [Range(0, 10)]
        public int Number;

        [Range(0, 10)]
        public float FloatingPointNumber;
        public char Symbol;
        public string String;

        [Header("Unity types")]
        public Vector2 Vector2;
        public Vector3 Vector3;
        public Vector4 Vector4;
        public Quaternion Quaternion;

        public UnityEngine.Object UnityEngineObjectAndItsSubClasses;

        [Header("List of supported types")]
        public List<int> ListOfInts;

        [SerializeField]
        private int _privateNumber;

        private void OnValidate()
        {
            Debug.Log("OnValidate is called");
        }

        private void Awake()
        {
            Debug.Log("Awake is called");
        }

        private void OnEnable()
        {
            Debug.Log("OnEnable is called");
        }

        private void OnDisable()
        {
            Debug.Log("OnDisable is called");
        }

        private void OnDestroy()
        {
            Debug.Log("OnDestroy is called");
        }
    }
}