using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerInput playerInput;

    private delegate void StartContactDelegate(Vector2 position, float time);

    void Awake()
    {
        playerInput = new PlayerInput();
    }

    void OnEnable()
    {
        playerInput.Enable();
    }

    void OnDisable()
    {
        playerInput.Disable();
    }

    void Start()
    {
        playerInput.Player.Contact.started += ctx => StartContact(ctx);
        //playerInput.Player.Contact.canceled += ctx => EndContact(ctx);
    }

    private void StartContact(InputAction.CallbackContext ctx)
    {
        Debug.Log("Start Contact");
    }
}
