using Game.Model;
using Game.View;
using VContainer.Unity;

namespace Game.Presenter
{
    public class HealthBarPresenter : IStartable
    {
        private readonly CharacterHealth _characterHealth;
        private readonly HealthBar _healthBar;

        public HealthBarPresenter(CharacterHealth characterHealth, HealthBar healthBar)
        {
            _characterHealth = characterHealth;
            _healthBar = healthBar;
        }

        public void Start()
        {
            // Initialize the health bar with current health values
            _healthBar.UpdateHealthBar(_characterHealth.CurrentHealth, _characterHealth.MaxHealth);

            // Subscribe to health changes
            _characterHealth.OnHealthChanged += _healthBar.UpdateHealthBar;
        }
    }
}