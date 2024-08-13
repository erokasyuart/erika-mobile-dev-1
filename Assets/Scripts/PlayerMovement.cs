using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //private bool dragging;
    //private Transform toDrag;
    //private float dist;
    //private Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        DragPlayer();
    }

    private void DragPlayer()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = GetWorldPosition();

            switch(touch.phase)
            {
                case TouchPhase.Began:
                    RaycastHit2D hit = Physics2D.Raycast(touchPos, Vector2.zero);
                    if (hit.collider != null)
                    {
                        Debug.Log("Touched " + hit.collider.gameObject.name);
                    }
                    break;
                case TouchPhase.Moved:
                    transform.position = new Vector3(touchPos.x, touchPos.y, 0);
                    break;
                case TouchPhase.Ended:
                    break;
            }
        }
    }

    private Vector2 GetWorldPosition()
    {
        Vector2 touchPos = Input.GetTouch(0).position;
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(touchPos);
        return worldPos;
    }
}
