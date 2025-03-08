using Game.Model;
using Leap.Forward;
using Leap.Forward.LightInject;
using UnityEngine;
using VContainer;

namespace Game
{
    public class Bootstraper : BootstraperBase
    {
        public CanvasGroup _fadeCanvas;

        public float _fadeDuration = 0.5f;

        public SaveFileSlots _saveFileSlots;

        protected override void Configure(IContainerBuilder builder)
        {
            base.Configure(builder);

            builder
                //.WithSelf()
                //.WithBootstraper(this)
                .WithSceneLoader()
                .WithPrefabManager()
                .WithUIManager()
                .WithSaveManager()
                .WithGameStateMachine()
                .WithGameState<MainMenuState>()
                .WithGameState<GameSceneState>()
                .WithFadeTransition(_fadeCanvas, _fadeDuration)
                .WithEntryPoint(OnStart);
        }
       
        private void OnStart()
        {
            Container.Inject(_saveFileSlots);

            if (InitialGameState.Type != null)
                Container.Resolve<IGameStateMachine>().Enter(InitialGameState.Type);
        }

        protected override void Awake()
        {
            base.Awake();

            DontDestroyOnLoad(_fadeCanvas.gameObject);
        }
    }
}