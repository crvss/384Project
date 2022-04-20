using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //public AudioClip clickTick;
    //AudioSource audioSource;

    public string levelOne;
    void Start()
    {
        ///audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        
    }
    public void StartGame()
    {
        //audioSource.PlayOneShot(clickTick);
        GameObject nameSpace = GameObject.FindGameObjectsWithTag("NameSpace")[0];
        nameSpace.SetActive(true);
    }
    public void nameEntered(string playerName)
    {
        PlayerData playerData = new PlayerData(playerName, 0, 0);
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
        //audioSource.PlayOneShot(clickTick);
        Application.Quit();
        Debug.Log("Quit");
    }
}
