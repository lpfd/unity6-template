using Game.Model;
using Leap.Forward.Composition;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public partial class Character : ContainerBase<Character>
    {
        [AttachedModule]
        private CharacterHealth _healthManager;

        protected override void OnEnable()
        {
            base.OnEnable();
        }
    }
}
