using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField]

    private UnityEvent onGamesStart;

    void Start()
    {
        onGamesStart?.Invoke();
    }

}
