using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBounce : MonoBehaviour
{
    //private GameObject platformSpawner;
    private PlatformSpawn platformSpawn;
    private int jumpCount = 0;

    void Start()
    {
        platformSpawn = GameObject.Find("PlatformSpawnManager").GetComponent<PlatformSpawn>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Rigidbody2D rb = other.gameObject.GetComponent<Rigidbody2D>();
        if (rb.velocity.y <= 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, 6f);

            //if (jumpCount < 1)
            //{
                platformSpawn.PlatformSpawned();
                GameManager.Height++;
                Destroy(this.gameObject, 2);
            //}
            // else if (jumpCount >= 0)
            // {
            //     Destroy(this.gameObject, 1);
            // }
        }
    }
}
