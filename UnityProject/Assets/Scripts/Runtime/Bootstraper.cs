using Leap.Forward;
using Leap.Forward.LightInject;
using System;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Game
{
    public class Bootstraper : BootstraperBase
    {
        public CanvasGroup _fadeCanvas;

        public float _fadeDuration = 0.5f;

        protected override void Configure(IContainerBuilder builder)
        {
            base.Configure(builder);

            builder
                //.WithSelf()
                //.WithBootstraper(this)
                .WithSceneLoader()
                .WithGameStateMachine()
                .WithGameState<MainMenuState>()
                .WithFadeTransition(_fadeCanvas, _fadeDuration)
                .WithEntryPoint(OnStart);
        }
       
        private void OnStart()
        {
            Container.Resolve<IGameStateMachine>().Enter<MainMenuState>();
        }

        public override void Awake()
        {
            base.Awake();

            DontDestroyOnLoad(_fadeCanvas.gameObject);
        }
    }
}