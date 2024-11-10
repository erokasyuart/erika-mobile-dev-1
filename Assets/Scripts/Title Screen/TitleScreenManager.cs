using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using TMPro;

public class TitleScreenManager : MonoBehaviour
{
    [SerializeField] private ParticleSystem shipEffect;
    private UIInputSystem uIInputSystem; // Input System
    private InputAction boostAction; // Input Action

    [SerializeField]private RectTransform buttonGraphic;
    private float pressedScale = 0.9f; // Scale when pressed
    private float transitionSpeed = 10f; // Speed of scaling back to normal
    private Vector3 originalScale;
    [SerializeField] private TextMeshProUGUI highScoreText;

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
        originalScale = buttonGraphic.localScale;
        highScoreText.text = "Best Height: " + PlayerPrefs.GetInt("HighScore", GameManager.Height).ToString() + "m";
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Main");
    }

    private void OnBoostPerformed(InputAction.CallbackContext context)
    {
        Debug.Log("Boost Performed - Effect Started");
        shipEffect.Play();  // Start the particle effect
        StartCoroutine(ScaleButton(Vector3.one * pressedScale));
    }

    private void OnBoostCanceled(InputAction.CallbackContext context)
    {
        Debug.Log("Boost Canceled - Effect Stopped");
        shipEffect.Stop();  // Stop the particle effect
        StartCoroutine(ScaleButton(originalScale));
    }

    private IEnumerator ScaleButton(Vector3 targetScale)
    {
        while (Vector3.Distance(buttonGraphic.localScale, targetScale) > 0.01f)
        {
            buttonGraphic.localScale = Vector3.Lerp(
                buttonGraphic.localScale, 
                targetScale, 
                transitionSpeed * Time.deltaTime
            );
            yield return null; // Wait for the next frame
        }

        buttonGraphic.localScale = targetScale; // Ensure final scale is exact
    }
}
