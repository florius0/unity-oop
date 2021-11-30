using Mobs;
using UnityEngine;

namespace Patterns.Factory
{
    [CreateAssetMenu(fileName = "Vampire Factory", menuName = "UnityOOP/Factory/Vampire Factory", order = 0)]
    public class VampireFactory : AbstractMobFactory
    {
        public override MobAreal CreateArealMob()
        {
            return new VampireAreal {Strength = Strength, Health = Health, Speed = Speed};
        }

        public override MobWalking CreateWalkingMob()
        {
            return new VampireWalking {Strength = Strength, Health = Health, Speed = Speed};
        }

        public override MobAquatic CreateAquaticMob()
        {
            return new VampireAquatic {Strength = Strength, Health = Health, Speed = Speed};
        }
    }
}