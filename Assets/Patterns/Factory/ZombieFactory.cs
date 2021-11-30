using UnityEngine;

namespace Patterns.Factory
{
    [CreateAssetMenu(fileName = "Zombie Factory", menuName = "UnityOOP/Factory/Zombie Factory", order = 0)]
    public class ZombieFactory : AbstractMobFactory
    {
        public override MobAreal CreateArealMob()
        {
            return new ZombieAreal {Strength = Strength, Health = Health, Speed = Speed};
        }

        public override MobWalking CreateWalkingMob()
        {
            return new ZombieWalking {Strength = Strength, Health = Health, Speed = Speed};
        }

        public override MobAquatic CreateAquaticMob()
        {
            return new ZombieAquatic {Strength = Strength, Health = Health, Speed = Speed};
        }
    }
}