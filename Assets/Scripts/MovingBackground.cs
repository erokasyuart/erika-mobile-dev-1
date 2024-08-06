using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A list of background gameobjects will move downwards until they reach a point, where they will start at the top again.
/// This will be attached to each sprite so that they can move independently.
/// </summary>
public class MovingBackground : MonoBehaviour
{
    private float speed = 1.0f;
    private float resetPoint = -6.0f;
    private float startPoint = 6.0f;

    void Start()
    {
        StartCoroutine(MoveBackground());
    }
    
    IEnumerator MoveBackground()
    {
        while (true) // Infinite loop to keep the background moving
        {
            transform.position += Vector3.down * speed * Time.deltaTime; // Move the background downwards

            if (transform.position.y <= resetPoint) // If the position of the sprites is less than the reset point
            {
                transform.position = new Vector3(transform.position.x, startPoint, transform.position.z); // Move it to the start point
            }

            yield return null;
        }
    }
}
