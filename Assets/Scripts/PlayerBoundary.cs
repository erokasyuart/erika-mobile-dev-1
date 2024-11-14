using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoundary : MonoBehaviour
{
    [SerializeField] private List<GameObject> boundaryObjects = new List<GameObject>();
    private Vector3 boundaryPosition;

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < boundaryObjects.Count; i++)
        {
            boundaryPosition = boundaryObjects[i].transform.position;
            boundaryPosition.y = transform.position.y;
            boundaryObjects[i].transform.position = boundaryPosition;
        }
    }
}
