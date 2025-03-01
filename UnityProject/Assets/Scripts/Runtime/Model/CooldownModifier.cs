using Leap.Forward.Composition;
using UnityEngine;

namespace Game
{
    public partial class CooldownModifier : ModuleBase<Character>, ICooldownModifier
    {
        [Tooltip("Cooldown multiplier")]
        public float multiplier = 1.0f;

        public float ModifyCooldown(float value)
        {
            return value * multiplier;
        }
    }

    public interface ICooldownModifier
    {
        float ModifyCooldown(float value);
    }
}
