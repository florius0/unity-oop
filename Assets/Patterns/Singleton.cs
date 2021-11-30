using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Patterns
{
    public abstract class AbstractSingletone : MonoBehaviour { }

    public abstract class Singleton<T> : AbstractSingletone where T : AbstractSingletone
    {
        public static T Instance;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this as T;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}