using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBounce : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject platformSpawner;
    private PlatformSpawn platformSpawn;
    void Start()
    {
        platformSpawn = platformSpawner.GetComponent<PlatformSpawn>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 300f);
        }
    }
}
