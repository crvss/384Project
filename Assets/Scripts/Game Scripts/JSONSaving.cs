using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JSONSaving : MonoBehaviour
{
    //private string path = "";
    private string persistentPath = "";

    // Start is called before the first frame update
    void Start()
    {
        SetPaths();
    }

    private void SetPaths()
    {
        //path = Application.dataPath + Path.AltDirectorySeparatorChar + "PlayerSave.json";
        persistentPath = Application.persistentDataPath + Path.AltDirectorySeparatorChar + "PlayerSave.json";
    }

    public void CreatePlayerData(string playerName, int score, int level)
    {
        PlayerData.playerName = playerName;
        PlayerData.score = score;
        PlayerData.level = level;
        SaveData();
    }
    // Update is called once per frame
    void Update()
    {
 
    }

    string PlayerDataString()
    {
        return PlayerData.playerName + " " + PlayerData.score + " " + PlayerData.level;
    }

    public void SaveData()
    {
        string savePath = persistentPath;
        Debug.Log("Saving data at " + savePath);
        Debug.Log(PlayerData.playerName);
        string json = JsonUtility.ToJson(PlayerDataString());
        Debug.Log(json);

        using StreamWriter writer = new StreamWriter(savePath);
        writer.Write(json);
    }

    public void LoadData()
    {
        using StreamReader reader = new StreamReader(persistentPath);
        string json = reader.ReadToEnd();

        string data = JsonUtility.FromJson<string>(json);
        Debug.Log(data);
    }
}
