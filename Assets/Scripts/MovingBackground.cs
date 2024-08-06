using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The first background should move down.
/// If it reached the end point, it should be destroyed.
/// The second background should continue to move down until it reaches y=0
/// then the movement stops.
/// </summary>
public class MovingBackground : MonoBehaviour
{
    private float speed = 1.0f;
    private float endPoint = -12.0f;

    void Start()
    {

    }

    void Update()
    {
        MoveDown();
        
        if (gameObject.name == "Horizon Background" && transform.position.y <= endPoint)
        {
            Destroy(gameObject);
        }

        if (gameObject.name == "Sky Background" && transform.position.y <= 0)
        {
            speed = 0;
        }
    }

    private void MoveDown()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
    
}
