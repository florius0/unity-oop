using UnityEngine;

namespace Patterns.Algorithm
{
    public class AlgorithmExample : MonoBehaviour
    {
        public AbstractMobSpawnAlgorithm MobSpawnAlgorithm;

        private void Start()
        {
            GetPos();
        }

        [ContextMenu("Get Position")]
        private void GetPos()
        {
            Debug.Log(MobSpawnAlgorithm.GetMobSpawnPosition());
        }
    }
}