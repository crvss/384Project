using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject nameSpace;

    public string levelOne;
    void Start()
    {

    }
    public void StartGame()
    {
        nameSpace.SetActive(true);
    }
    public void nameEntered(string playerName)
    {
        GameObject save = GameObject.FindGameObjectsWithTag("Save")[0];
        PlayerData.playerName = playerName;
        save.SendMessage("CreatePlayerData");
        SceneManager.LoadScene(levelOne);
    }
    public void OpenLeaderboard()
    {

    }
    public void CloseLeaderboard()
    {

    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
