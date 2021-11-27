using UnityEngine;

namespace Patterns
{
    public class SimpleSingleton : Singleton<SimpleSingleton>
    {
        public AudioSource AudioSource;

        private void Start()
        {
            AudioSource = GetComponent<AudioSource>();
        }
    }
}