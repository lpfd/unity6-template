using UnityEngine;

namespace Game.Model
{
    public class CharacterHealth : MonoBehaviour
    {
        public float MaxHealth = 100f;
        public float CurrentHealth { get; private set; }

        public delegate void HealthChanged(float currentHealth, float maxHealth);
        public event HealthChanged OnHealthChanged;

        private void Awake()
        {
            CurrentHealth = MaxHealth;
        }

        public void TakeDamage(float amount)
        {
            CurrentHealth = Mathf.Clamp(CurrentHealth - amount, 0, MaxHealth);
            OnHealthChanged?.Invoke(CurrentHealth, MaxHealth);
        }

        public void Heal(float amount)
        {
            CurrentHealth = Mathf.Clamp(CurrentHealth + amount, 0, MaxHealth);
            OnHealthChanged?.Invoke(CurrentHealth, MaxHealth);
        }
    }
}
