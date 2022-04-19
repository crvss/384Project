using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    [SerializeField] GameObject deathMenu;

    public void playerDied()
    {
        Debug.Log("Pause");
        deathMenu.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void retry()
    {
        deathMenu.SetActive(false);
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void home(int sceneID)
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(sceneID);
    }
}
