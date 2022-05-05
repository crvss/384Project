using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AchievementsMenu : MonoBehaviour
{
    public GameObject achieveState;

    private void Awake()
    {
        if (PlayerPrefs.GetInt("AchieveBB") == 404)
        {
            UnlockAch();
        }
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void UnlockAch()
    {
        achieveState.GetComponent<TMPro.TextMeshProUGUI>().text = "Achievement Unlocked";
    }
}
