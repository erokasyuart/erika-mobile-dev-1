using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class Save : MonoBehaviour
{
    int currentHeight;
    int currentTimePlayed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SaveGame()
    {
        string path = Application.persistentDataPath + "/game.save";
        FileStream file;

        if (File.Exists(path))
        {
            file = File.OpenWrite(path);
        }
        else
        {
            file = File.Create(path);
        }

        GameData data = new GameData(currentHeight, currentTimePlayed);
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(file, data);
        file.Close();
    }

    public void LoadGame()
    {
        string path = Application.persistentDataPath + "/game.save";
        FileStream file;

        if(File.Exists(path))
        {
            file = File.OpenRead(path);
        }
        else
        {
            Debug.LogError("File not found");
            return;
        }



        BinaryFormatter bf = new BinaryFormatter();
        GameData data = (GameData)bf.Deserialize(file);
        file.Close();

        currentHeight = data.height;
        currentTimePlayed = data.timePlayed;
    }
}
