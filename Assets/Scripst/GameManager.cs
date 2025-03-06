using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField]

    private UnityEvent onGamesStart;
    [SerializeField]
       private UnityEvent onRespawnGame;
       [SerializeField]
       private float secondsToRestart = 3f;

    void Start()
    {
        onGamesStart?.Invoke();
    }

    public void PlayerLose()
    {
        Invoke(nameof(ResetarGame),secondsToRestart);

    }
    private void ResetarGame()
    {
        onRespawnGame?.Invoke();
    }

}
