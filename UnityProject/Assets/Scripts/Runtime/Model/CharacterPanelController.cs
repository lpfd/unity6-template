using Game.Model;
using Leap.Forward.Composition;
using UnityEngine;
using UnityEngine.UIElements;

namespace Game
{
    [RequireComponent(typeof(UIDocument))]
    public partial class CharacterPanelController : ModuleBase<Character>
    {
        private CharacterHealth _healthManager;

        private UIDocument _document;
        private ProgressBar _healthBar;

        public override void SetupModules()
        {
            base.SetupModules();

            _healthManager = Container.HealthManager;
            _healthManager.OnHealthChanged += UpdatePanel;

            _document = GetComponent<UIDocument>();
            _healthBar = _document.rootVisualElement?.Q<ProgressBar>("Health");

            UpdatePanel();
        }

        private void UpdatePanel()
        {
            _healthBar.value = _healthManager._health;
            _healthBar.highValue = _healthManager._maxHealth;
        }
    }
}
