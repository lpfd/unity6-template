using Leap.Forward;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class MainMenuState : IGameState
    {
        private readonly ISceneLoader _sceneLoader;

        public MainMenuState(ISceneLoader sceneLoader)
        {
            _sceneLoader = sceneLoader;
        }

        public void Enter()
        {
            _sceneLoader.Load("MainMenu");
        }

        public void Exit()
        {
        }
    }

}
