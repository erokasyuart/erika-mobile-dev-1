using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBounce : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject platformSpawner;
    private PlatformSpawn platformSpawn;
    //private bool hasTouched = false;
    private int jumpCount = 0;

    void Start()
    {
        platformSpawn = GameObject.FindWithTag("PlatformSpawner").GetComponent<PlatformSpawn>();
        //platformSpawn = platformSpawner.GetComponent<PlatformSpawn>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Rigidbody2D rb = other.gameObject.GetComponent<Rigidbody2D>();
        // if(other.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        // {
        //     other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 250f);
        if (rb.velocity.y <= 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, 6f);

            if (jumpCount < 1)
            {
                jumpCount++;
                platformSpawn.PlatformSpawned(this.gameObject);
                GameManager.height++;
            }
            else if (jumpCount >= 1)
            {
                //break cloud platform
            }
        }
    }
}
