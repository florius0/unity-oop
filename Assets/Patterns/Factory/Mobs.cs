namespace Patterns.Factory
{
    public abstract class Mob
    {
        public float Speed;
        public float Health;
        public float Strength;

        public override string ToString()
        {
            return $"{GetType()} {{Speed = {Speed}, Health = {Health}, Strength = {Strength}}}";
        }
    }

    public abstract class MobAreal : Mob { }

    public abstract class MobWalking : Mob { }

    public abstract class MobAquatic : Mob { }

    public class ZombieAreal : MobAreal { }

    public class ZombieWalking : MobWalking { }

    public class ZombieAquatic : MobAquatic { }

    public class VampireAreal : MobAreal { }

    public class VampireWalking : MobWalking { }

    public class VampireAquatic : MobAquatic { }
}