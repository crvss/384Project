using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AchievementsMenu : MonoBehaviour
{
    public GameObject achieveState;
    public static bool achieveFlag = false;

    private void Awake()
    {
        if (achieveFlag)
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
