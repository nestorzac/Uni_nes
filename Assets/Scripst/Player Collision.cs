using UnityEngine;
using UnityEngine.Events;
 
public class PlayerCollission : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onPlayerLose;
    private Dash dash;
 
    private void Start()
    {
        dash = GetComponent<Dash>();  
    }
 
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            if(dash.IsDashing)
            {
                Destroy(collision.gameObject);
            }
            else
            {
                onPlayerLose?.Invoke();
            }
        }
    }
}
