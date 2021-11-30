using UnityEngine;

namespace Patterns.Algorithm
{
    [CreateAssetMenu(fileName = "Random MobSpawnAlgorithm", menuName = "UnityOOP/Algorithm/Random MobSpawnAlgorithm", order = 0)]
    public class RandomMobSpawnAlgorithm : AbstractMobSpawnAlgorithm
    {
        [Range(0, 10)]
        public float From;

        [Range(0, 10)]
        public float To;

        public override Vector3 GetMobSpawnPosition()
        {
            return new Vector3(Random.Range(From, To), Random.Range(From, To), Random.Range(From, To));
        }

        private void OnValidate()
        {
            if (To < From) To = From;
        }
    }
}