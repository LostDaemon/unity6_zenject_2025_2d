public class GameLoopState : IGameState
{
    public void Enter()
    {
        UnityEngine.Debug.Log("GameLoopState ENTERED");
    }

    public void Exit() { }
}