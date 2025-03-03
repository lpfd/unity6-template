using Game.ViewModel;
using UnityEngine;

namespace Game.Model
{
    public class CharacterHealth : MonoBehaviour
    {
        public CharacterStats _charaterStats;

        public delegate void HealthChanged(float currentHealth, float maxHealth);
        public event HealthChanged OnHealthChanged;

        private void Awake()
        {
        }

        public void TakeDamage(float amount)
        {
            _charaterStats._health = Mathf.Clamp(_charaterStats._health - amount, 0, _charaterStats._maxHealth);
            OnHealthChanged?.Invoke(_charaterStats._health, _charaterStats._maxHealth);
        }

        public void Heal(float amount)
        {
            _charaterStats._health = Mathf.Clamp(_charaterStats._health + amount, 0, _charaterStats._maxHealth);
            OnHealthChanged?.Invoke(_charaterStats._health, _charaterStats._maxHealth);
        }
    }
}
