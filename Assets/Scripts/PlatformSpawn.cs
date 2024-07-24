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
    private int timeBetweenSpawn = 2;
    private float randPlatformScaleX;
    private float randomPlatformPosX;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            randomPlatformPosX = Random.Range(-7f, 7f);
            randPlatformScaleX = Random.Range(2.5f, 6.5f);
            Instantiate(platformPrefab, new Vector3(randomPlatformPosX, transform.position.y, transform.position.z), Quaternion.identity).transform.localScale = new Vector3(randPlatformScaleX, 0.5f, 1);

            //Instantiate(platformPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(timeBetweenSpawn);
        }
    }
}
