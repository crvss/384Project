using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievements : MonoBehaviour
{
    public GameObject achievePanel;
    public GameObject achieveTitle;
    public GameObject achieveDesc;
    public AudioSource achieveSound;

    public bool achieveActive = false;

    public static int achieveBBNumber;
    public GameObject achieveBBImage;
    public int achieveBBTrigger = 20;
    public int achieveBBCode; //unique achievement identifier and ensures users dont get two of the same achievement

    void Update()
    {
        //Uncomment to reset achievement code for debugging
        PlayerPrefs.SetInt("AchieveBB", 0);

        achieveBBCode = PlayerPrefs.GetInt("AchieveBB");
        if (achieveBBNumber == achieveBBTrigger && achieveBBCode != 404)
        {
            StartCoroutine(BBTrigger());
        }
    }

    IEnumerator BBTrigger()
    {
        AchievementsMenu.achieveFlag = true;

        achieveActive = true;
        achieveBBCode = 404;
        PlayerPrefs.SetInt("AchieveBB", achieveBBCode);
        achieveSound.Play();
        achievePanel.SetActive(true);
        achieveBBImage.SetActive(true);
        achieveTitle.GetComponent<TMPro.TextMeshProUGUI>().text = "Brick Breaker";
        achieveDesc.GetComponent<TMPro.TextMeshProUGUI>().text = "Break 20 Bricks";
        yield return new WaitForSeconds(5);

        achievePanel.SetActive(false);
        achieveBBImage.SetActive(false);
        achieveTitle.GetComponent<TMPro.TextMeshProUGUI>().text = "";
        achieveDesc.GetComponent<TMPro.TextMeshProUGUI>().text = "";
        achieveActive = false;
    }
}
