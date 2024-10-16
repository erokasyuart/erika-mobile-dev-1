using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class TitleScreenManager : MonoBehaviour
{
    [SerializeField] private ParticleSystem shipEffect;
    private UIInputSystem uIInputSystem; // Input System
    private InputAction boostAction; // Input Action

    private void Awake()
    {
        uIInputSystem = new UIInputSystem();
        boostAction = uIInputSystem.TitleScreen.Graphic;
    }

    private void OnEnable()
    {
        uIInputSystem.Enable();

        boostAction.performed += OnBoostPerformed;
        boostAction.canceled += OnBoostCanceled;

        boostAction.Enable();
    }

    private void OnDisable()
    {
        uIInputSystem.Disable();

        boostAction.performed -= OnBoostPerformed;
        boostAction.canceled -= OnBoostCanceled;

        boostAction.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //uIInputSystem.TitleScreen.Graphic.performed += ctx => PlayBoostEffect();
        // if (boostAction.phase == InputActionPhase.Started)
        // {
        //     Debug.Log("Action Started");
        //     shipEffect.Play();
        // }
        // else if (boostAction.phase == InputActionPhase.Canceled)
        // {
        //     Debug.Log("Action Canceled");
        //     shipEffect.Stop();
        // }
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Main");
    }

    public void QuitButton()
    {
        Application.Quit();
    }


    private void OnBoostPerformed(InputAction.CallbackContext context)
    {
        Debug.Log("Boost Performed - Effect Started");
        shipEffect.Play();  // Start the particle effect
    }

    private void OnBoostCanceled(InputAction.CallbackContext context)
    {
        Debug.Log("Boost Canceled - Effect Stopped");
        shipEffect.Stop();  // Stop the particle effect
    }
}
