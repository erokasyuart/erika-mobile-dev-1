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

    public void PlatformSpawned()
    {
        randomPlatformPosX = Random.Range(-2.5f, 2.5f);
        newPlatformPosY = lastPlatformPosY + 1.6f;
        Instantiate(platformPrefab, new Vector3(randomPlatformPosX, newPlatformPosY, 0), Quaternion.identity);
        lastPlatformPosY = newPlatformPosY;
    }

    private void Update()
    {
        if (player.transform.position.y < lastPlatformPosY - 10)
        {
            Debug.Log("Game Over");
        }
    }
}
