using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUIManager : MonoBehaviour
{
    //get set height from game manager
    [SerializeField] private TextMeshProUGUI heightText;
    public int height
    {
        get
        {
            return GameManager.height;
        }
        set
        {
            GameManager.height = value;
            heightText.text = ($"{value.ToString()} m");
        }
    }

    [SerializeField] private TextMeshProUGUI timeText;
    public int timePlayed
    {
        get
        {
            return GameManager.timePlayed;
        }
        set
        {
            GameManager.timePlayed = value;
            timeText.text = ($"{value.ToString()} s");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
