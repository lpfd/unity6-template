using Leap.Forward;

namespace Game
{
    /// <summary>
    /// Main menu state. Displays main menu.
    /// </summary>
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
