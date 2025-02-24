using UnityEngine;
using UnityEngine.UIElements;

namespace Game.View
{
    public class HealthBar : VisualElement
    {
        private VisualElement _healthBar;

        public new class UxmlFactory : UxmlFactory<HealthBar, UxmlTraits> { }

        public HealthBar()
        {
            var visualTree = Resources.Load<VisualTreeAsset>("HealthBar");
            visualTree.CloneTree(this);

            var styleSheet = Resources.Load<StyleSheet>("HealthBar");
            styleSheets.Add(styleSheet);

            _healthBar = this.Q<VisualElement>("healthBar");
        }

        public void UpdateHealthBar(float currentHealth, float maxHealth)
        {
            float percentage = currentHealth / maxHealth;
            _healthBar.style.width = new Length(percentage * 100, LengthUnit.Percent);
        }
    }
}