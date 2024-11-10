using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{
    [SerializeField]private GameObject platformPrefab;
    private float randomPlatformPosX;
    private float lastPlatformPosY;
    private float newPlatformPosY;
    [SerializeField] private GameObject player;

    void Start()
    {
        lastPlatformPosY = 3; // last platform when the game starts
    }

    /// <summary>
    /// Spawns a new platform when the player collides with the platform
    /// </summary>
    public void PlatformSpawned()
    {
        randomPlatformPosX = Random.Range(-2.5f, 2.5f); // random x position for the platform
        newPlatformPosY = lastPlatformPosY + 1.6f; // new y position for the platform
        Instantiate(platformPrefab, new Vector3(randomPlatformPosX, newPlatformPosY, 0), Quaternion.identity); // spawn the platform
        lastPlatformPosY = newPlatformPosY; // set the last platform pos to the new platform
    }

    private void Update()
    {
        if (player.transform.position.y < lastPlatformPosY - 20) // if the player falls
        {
            //Debug.Log("Game Over"); // game over
        }
    }
}
