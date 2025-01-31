using Leap.Forward;
using Leap.Forward.LightInject;
using UnityEngine;

namespace Game
{
    public class Bootstraper : BootstraperBase
    {
        IServiceContainer _service;
        private IGameStateMachine _stateMachine;

        public CanvasGroup _fadeCanvas;

        public float _fadeDuration = 0.5f;

        public Bootstraper()
        {
            _service = new ServiceContainer();

            _service
                .WithSelf()
                .WithBootstraper(this)
                .WithSceneLoader()
                .WithGameStateMachine()
                .WithGameState<MainMenuState>();

            _stateMachine = _service.GetInstance<IGameStateMachine>();
        }

        public override void Awake()
        {
            base.Awake();

            DontDestroyOnLoad(_fadeCanvas.gameObject);

            _service.WithFadeTransition(_fadeCanvas, _fadeDuration);

            _stateMachine.Enter<MainMenuState>();
        }
    }
}