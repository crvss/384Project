using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    [SerializeField] GameObject deathMenu;

    public void playerDied()
    {
        deathMenu.SetActive(true);
    }

    public void retry()
    {
        deathMenu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void home(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
