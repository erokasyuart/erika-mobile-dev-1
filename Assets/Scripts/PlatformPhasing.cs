using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* One collider
* starts as trigger on until the player enters it.
* then it becomes a collider and the player can stand on top of the platform
*/

public class PlatformPhasing : MonoBehaviour
{
    private BoxCollider2D squareCollider;
    public PlatformMove platformMoveScript;
    public PlatformSpawn platformSpawnScript;


    // Start is called before the first frame update
    void Start()
    {
        squareCollider = GetComponent<BoxCollider2D>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            squareCollider.isTrigger = false;
        }
    }

}
