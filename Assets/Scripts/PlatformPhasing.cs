using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* The player can jump from below and through the platform
* Then the top of the platform should be solid
*/

public class PlatformPhasing : MonoBehaviour
{
    private bool playerOnTop = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            playerOnTop = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            playerOnTop = false;
        }
    }


}
