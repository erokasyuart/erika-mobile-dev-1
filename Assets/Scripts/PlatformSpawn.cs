using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{
    // random size platform
    // instantiate
    // clone has moving script.
    // random position
    //random scale

    [SerializeField]private GameObject platformPrefab;
    //private float timeBetweenSpawn = 2f;
    //private float randPlatformScaleX;
    private float randomPlatformPosX;
    public PlatformSpawn Instance;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(Spawn());
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
    }

    // private IEnumerator Spawn()
    // {
    //     while (true)
    //     {
    //         randomPlatformPosX = Random.Range(-2.5f, 2.5f);
    //         //randPlatformScaleX = Random.Range(1f, 2f);
    //         //Instantiate(platformPrefab, new Vector2(randomPlatformPosX, transform.position.y), Quaternion.identity).transform.localScale = new Vector2(randPlatformScaleX, 0.2f);
    //         Instantiate(platformPrefab, new Vector2(randomPlatformPosX, transform.position.y), Quaternion.identity);

    //         //Instantiate(platformPrefab, transform.position, Quaternion.identity);
    //         yield return new WaitForSeconds(timeBetweenSpawn);
    //     }
    // }

    public void PlatformSpawned()
    {
        randomPlatformPosX = Random.Range(-2.5f, 2.5f);
        Instantiate(platformPrefab, new Vector2(randomPlatformPosX, transform.position.y), Quaternion.identity);
    }
}
