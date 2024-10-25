using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameManager Instance { get; private set; }
    public static int height;
    public static int Height
    {
        get
        {
            return height;
        }
        set
        {
            height = value;
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

    [SerializeField] private TextMeshProUGUI heightText;
    [SerializeField] private TextMeshProUGUI timeText;

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
        heightText.text = ($"{height.ToString()}m");
        timeText.text = FormatTime(timePlayed);
    }

    private string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
