using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{
    [SerializeField]private GameObject platformPrefab;
    private float randomPlatformPosX;

    void Start()
    {

    }

    public void PlatformSpawned(GameObject platform)
    {
        randomPlatformPosX = Random.Range(-2.5f, 2.5f);
        Instantiate(platformPrefab, new Vector2(randomPlatformPosX, platform.transform.position.y + 6f), Quaternion.identity);
    }
}
