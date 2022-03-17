using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string levelOne;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void PlayGame()
    {
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
