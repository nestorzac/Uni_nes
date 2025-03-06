using System.Collections.Generic;
using UnityEngine;

public class PlatformInstantiate : MonoBehaviour
{
    [SerializeField]
    private List <GameObject> platforms;
    [SerializeField]
    private Transform platformsPosition;
    [SerializeField]
    private float distanceBetweenPlataforms = 2f;
    [SerializeField]
    private int initialPlatforms = 10;
    private float offsetPositionX = 0f;
    private void Start()
    {
        offsetPositionX = 0;
        InstantiatePlatforms(10);
    }
    public void InstantiatePlatforms(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            int randomIndex = Random.Range(0, platforms.Count);
            if (offsetPositionX != 0)
            {
                offsetPositionX += platforms[randomIndex].GetComponent<BoxCollider>().size.x * 0.5f;
            }
            GameObject platform = Instantiate(platforms[randomIndex], new Vector3(offsetPositionX, platformsPosition.position.y, platformsPosition.position.z), Quaternion.identity);
            offsetPositionX += distanceBetweenPlataforms + platform.GetComponent<BoxCollider>().size.x * 0.5f;
            platform.transform.SetParent(transform);
        }
    }

    public void Restart()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
        Start();
    }
}
