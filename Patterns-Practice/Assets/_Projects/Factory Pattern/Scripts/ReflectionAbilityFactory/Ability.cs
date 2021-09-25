using UnityEngine;

namespace Gisha.PatternsPractice.FactoryPattern.ReflectionAbilityFactory
{
    public abstract class Ability
    {
        public abstract string Name { get; }
        public abstract void Process();
    }

    public class LaunchFireballAbility : Ability
    {
        public override string Name => "Fireball";
        public override void Process()
        {
            Debug.Log($"Player have casted {Name}");
        }
    }

    public class LaunchIceShardAbility : Ability
    {
        public override string Name => "IceShard";
        public override void Process()
        {
            Debug.Log($"Player have casted {Name}");
        }
    }
    
    public class SelfHealAbility : Ability
    {
        public override string Name => "Healing";
        public override void Process()
        {
            Debug.Log($"Player have casted {Name}");
        }
    }
    
    public class DashAbility : Ability
    {
        public override string Name => "Dash";
        public override void Process()
        {
            Debug.Log($"Player have casted {Name}");
        }
    }
}