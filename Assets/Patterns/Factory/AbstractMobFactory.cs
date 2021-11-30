using UnityEngine;

namespace Patterns.Factory
{
    public abstract class AbstractMobFactory : ScriptableObject
    {
        [Range(0, 10)]
        public float Strength;

        [Range(0, 10)]
        public float Speed;

        [Range(0, 10)]
        public float Health;

        public abstract MobAreal CreateArealMob();

        public abstract MobWalking CreateWalkingMob();

        public abstract MobAquatic CreateAquaticMob();
    }
}