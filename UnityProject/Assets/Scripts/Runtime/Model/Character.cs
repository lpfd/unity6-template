using Leap.Forward.Composition;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public partial class Character : ContainerBase<Character>
    {
        [AttachedModule]
        private List<ICooldownModifier> cooldownModifier = new List<ICooldownModifier>();

        protected override void OnEnable()
        {
            base.OnEnable();

            Debug.Log($"Cooldown = {EvaluateCooldown(1)}");
        }

        private float EvaluateCooldown(float v)
        {
            foreach (var modifier in CooldownModifier)
            {
                v = modifier.ModifyCooldown(v);
            }
            return v;
        }
    }
}
