using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public static int height;
    public static int Height
    {
        get => height;
        set
        {
            height = value;
            if (Instance != null) // Check if Instance is set before calling UpdateUI
            {
                Instance.UpdateUI();
            }
            if (height > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", height);
                PlayerPrefs.Save();
            }
        }
    }
    
    public static float timePlayed;
    public static float TimePlayed
    {
        get
        {
            return timePlayed;
        }
        set
        {
            timePlayed = value;
        }
    }

    public TextMeshProUGUI heightText;
    public TextMeshProUGUI timeText;

     private void Awake()
    {
        if (Instance == null)  // If no instance exists, set this as the instance
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);  // Optional: Keep GameManager across scenes
        }
        else
        {
            Destroy(gameObject);  // Destroy duplicate instances
        }
    }

    private void Start()
    {
        UpdateUI();
        timePlayed = 0;
        height = 0;
    }

    private void Update()
    {
        timePlayed += Time.deltaTime;
    }

    private void UpdateUI()
    {
        if (heightText != null && timeText != null)
        {
            heightText.text = $"{height}m";
            timeText.text = FormatTime(timePlayed);
        }
        else if (heightText == null)
        {
            heightText = GameObject.Find("Height").GetComponent<TextMeshProUGUI>();
        }
        else if (timeText == null)
        {
            timeText = GameObject.Find("Time").GetComponent<TextMeshProUGUI>();
        }
    }

    private string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
