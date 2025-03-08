using Leap.Forward;
using Leap.Forward.SaveFiles;

namespace Game
{
    /// <summary>
    /// Game screen state. Displays game scene.
    /// </summary>
    public class GameSceneState : IGameState, IGameState<SaveFileContent>
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

        public void Enter(SaveFileContent payload)
        {
            _sceneLoader.Load(payload.SceneName);
        }

        public void Exit()
        {
        }
    }
}
