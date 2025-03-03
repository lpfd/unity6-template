using Leap.Forward.Composition;
using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace Game.Model
{
    public partial class CharacterHealth : ModuleBase<Character>
    {
        public float _health = 100;

        public float _maxHealth = 100;

        public event Action OnHealthChanged;

        private void Awake()
        {
        }

        public void TakeDamage(float amount)
        {
            var prevValue = _health;
            _health = Mathf.Clamp(_health - amount, 0, _maxHealth);
            if (prevValue != _health)
            {
                OnHealthChanged?.Invoke();
            }
        }

        public void Heal(float amount)
        {
            var prevValue = _health;
            _health = Mathf.Clamp(_health + amount, 0, _maxHealth);
            if (prevValue != _health)
            {
                OnHealthChanged?.Invoke();
            }
        }
    }


}
