using UnityEngine;

namespace Patterns.Algorithm
{
    [CreateAssetMenu(fileName = "Fixed MobSpawnAlgorithm", menuName = "UnityOOP/Algorithm/Fixed MobSpawnAlgorithm", order = 0)]
    public class FixedMobSpawnAlgorithm : AbstractMobSpawnAlgorithm
    {
        public Vector3 FixedPosition;

        public override Vector3 GetMobSpawnPosition()
        {
            return FixedPosition;
        }
    }
}