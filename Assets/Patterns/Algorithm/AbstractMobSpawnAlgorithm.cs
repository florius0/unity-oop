using UnityEngine;

namespace Patterns.Algorithm
{
    public abstract class AbstractMobSpawnAlgorithm : ScriptableObject
    {
        public abstract Vector3 GetMobSpawnPosition();
    }
}