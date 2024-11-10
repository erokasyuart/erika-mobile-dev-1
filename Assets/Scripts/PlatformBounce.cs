using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBounce : MonoBehaviour
{
    private PlatformSpawn platformSpawn;

    void Start()
    {
        platformSpawn = GameObject.Find("PlatformSpawnManager").GetComponent<PlatformSpawn>(); // find the PlatformSpawn script
    }

    /// <summary>
    /// When the player collides with the platform, the player will bounce and a new platform will spawn
    /// </summary>
    /// <param name="other">other is the player's collider</param>
    private void OnCollisionEnter2D(Collision2D other)
    {
        Rigidbody2D rb = other.gameObject.GetComponent<Rigidbody2D>(); // get the rigidbody of the player
        if (rb.velocity.y <= 0) // if the player is not moving
        {
            rb.velocity = new Vector2(rb.velocity.x, 6f); // make the player bounce
            
            platformSpawn.PlatformSpawned(); // spawn a new platform
            GameManager.Height++; // add to the height score
            Destroy(this.gameObject, 2); // destroy the platform after 2 seconds
            
        }
    }
}
