using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public int height;
    public int timePlayed;

    public GameData(int height, float timePlayed)
    {
        height = GameManager.height;
        timePlayed = GameManager.timePlayed;
    }
}
