using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JSONSaving : MonoBehaviour
{
    //private string path = "";
    private string persistentPath = "";
    private PlayerTemp playerTemp;

    void Start()
    {
        SetPaths();
    }

    private void SetPaths()
    {
        //path = Application.dataPath + Path.AltDirectorySeparatorChar + "PlayerSave.json";
        persistentPath = Application.persistentDataPath + Path.AltDirectorySeparatorChar + "PlayerSave.json";
    }

    public void CreatePlayerData()
    {
        if (PlayerData.score == 0)
        {
            playerTemp = new PlayerTemp(PlayerData.playerName, 0, 0);
        }
        else
        {
            playerTemp = new PlayerTemp(PlayerData.playerName, PlayerData.score, PlayerData.level);
        }
        SaveData();
    }

    string PlayerDataString()
    {
        return PlayerData.playerName + " " + PlayerData.score + " " + PlayerData.level;
    }

    public void SaveData()
    {
        string savePath = persistentPath;
        Debug.Log("Saving data at " + savePath);
        
        string json = JsonUtility.ToJson(playerTemp);
        Debug.Log(json);

        using StreamWriter writer = new StreamWriter(savePath);
        writer.Write(json);
    }

    public void LoadData()
    {
        using StreamReader reader = new StreamReader(persistentPath);
        string json = reader.ReadToEnd();

        PlayerTemp data = JsonUtility.FromJson<PlayerTemp>(json);
        Debug.Log(data.ToString());
    }
}
