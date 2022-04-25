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
    public int achieveBBCode; //unique achievement identifier

    void Update()
    {
        achieveBBCode = PlayerPrefs.GetInt("AchieveBB");
        if (achieveBBNumber == achieveBBTrigger && achieveBBCode != 404)
        {
            StartCoroutine(BBTrigger());
        }
    }

    IEnumerator BBTrigger()
    {
        achieveActive = true;
        achieveBBCode = 404;
        PlayerPrefs.SetInt("AchieveBB", achieveBBCode);
        //play sound
        achieveTitle.GetComponent<Text>().text = "Brick Breaker";
        achieveDesc.GetComponent<Text>().text = "Break 20 Bricks";
        achievePanel.SetActive(true);
        achieveBBImage.SetActive(true);
        yield return new WaitForSeconds(5);

        achievePanel.SetActive(false);
        achieveBBImage.SetActive(false);
        achieveTitle.GetComponent<Text>().text = "";
        achieveDesc.GetComponent<Text>().text = "";
        achieveActive = false;
    }
}
