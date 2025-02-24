using Game.Model;
using Leap.Forward;
using UnityEngine.UIElements;
using UnityEngine;
using VContainer;
using VContainer.Unity;
using Game.View;
using Game.Presenter;
using UnityEditor;

namespace Game
{
    [DefaultExecutionOrder(100)]
    public class GameLifetimeScope : EnsureBootstraper
    {
        [SerializeField] private UIDocument uiDocument;

        protected override void Configure(IContainerBuilder builder)
        {
            base.Configure(builder);

            // Register CharacterHealth as a singleton
            builder.RegisterComponentInHierarchy<CharacterHealth>().AsSelf().AsImplementedInterfaces();

            // Register the HealthBar
            builder.RegisterComponent(uiDocument.rootVisualElement.Q<HealthBar>()).AsSelf().AsImplementedInterfaces();

            // Register the HealthBarPresenter
            builder.RegisterEntryPoint<HealthBarPresenter>(Lifetime.Singleton).AsSelf();
        }
    }
#if UNITY_EDITOR
    [CustomEditor(typeof(GameLifetimeScope))]
    public class GameLifetimeScopeEditor : EnsureBootstraperEditor
    {
    }
#endif
}
