using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{
    // random size platform
    // instantiate
    // clone has moving script.

    [SerializeField]private GameObject platformPrefab;
    private int timeBetweenSpawn = 2;
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
            Instantiate(platformPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(timeBetweenSpawn);
        }
    }
}
