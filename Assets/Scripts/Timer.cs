/// <remarks>
/// Author: Erika Stuart
/// Date Created: 30/07/2024
/// Date Last Modified: 07/08/2024
/// Bugs: N/A
/// </remarks>

/// <summary>
/// This script counts the current play time and displays it to the player in the format of "00:00".
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Counting());
    }

    public IEnumerator Counting()
    {
        float time = 0;
        while (true)
        {
            time += UnityEngine.Time.deltaTime;
            timeText.text = time.ToString("F2");
            yield return null;
        }
    }
}
