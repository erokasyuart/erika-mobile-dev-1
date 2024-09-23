using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // need to set a boolean to true when the touch position is within the player's collider
    private bool onPlayer = false;
    [SerializeField] private Camera cam;

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
                    if (hit.collider != null && hit.collider.gameObject.name == "Player")
                    {
                        Debug.Log("Touched " + hit.collider.gameObject.name);
                        onPlayer = true;
                    }

                    break;
                case TouchPhase.Moved:
                    if (!onPlayer)
                    {
                        return;
                    }
                    transform.position = new Vector3(touchPos.x, transform.position.y, 0);
                    cam.transform.position = new Vector3(0, transform.position.y, -5);
                    break;
                case TouchPhase.Ended:
                    onPlayer = false;
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
