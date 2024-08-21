using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPhasing : MonoBehaviour
{
    [SerializeField] private BoxCollider2D squareCollider;
    private bool hasAlreadyTouched = false;

    // Start is called before the first frame update
    void Start()
    {
        squareCollider.enabled = false;
    }

    // if the player enters the bottom collider,
    // the actual collider will let the player
    // pass through and stand on top of the platform
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            squareCollider.enabled = true;

            if (!hasAlreadyTouched)
            {
                hasAlreadyTouched = true;
                GameManager.height++;
            }
        }
    }

    // if the player exits the bottom collider,
    // the actual collider will not let the player
    // pass through and fall through the platform
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            squareCollider.enabled = false;
        }
    }

}
