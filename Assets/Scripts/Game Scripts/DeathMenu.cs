using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    [SerializeField] GameObject deathMenu;

    public void PlayerDied()
    {
        deathMenu.SetActive(true);
    }

    public void Retry()
    {
        deathMenu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Home(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
