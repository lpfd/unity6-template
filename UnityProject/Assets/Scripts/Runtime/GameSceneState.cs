using Leap.Forward;

namespace Game
{
    /// <summary>
    /// Game screen state. Displays game scene.
    /// </summary>
    public class GameSceneState : IGameState
    {
        private readonly ISceneLoader _sceneLoader;

        public GameSceneState(ISceneLoader sceneLoader)
        {
            _sceneLoader = sceneLoader;
        }

        public void Enter()
        {
            _sceneLoader.Load("GameScreen");
        }

        public void Exit()
        {
        }
    }
}
