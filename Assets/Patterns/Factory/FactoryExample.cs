using UnityEngine;

namespace Patterns.Factory
{
    public class FactoryExample : MonoBehaviour
    {
        public AbstractMobFactory MobFactory;

        private void Start()
        {
            Debug.Log("Creating monsters");

            Debug.Log(MobFactory.CreateAquaticMob());
            Debug.Log(MobFactory.CreateWalkingMob());
            Debug.Log(MobFactory.CreateArealMob());
        }
    }
}