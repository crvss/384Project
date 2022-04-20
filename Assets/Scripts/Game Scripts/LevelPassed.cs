using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelPassed : MonoBehaviour
{
    [SerializeField] GameObject levelPassed;

    public void levelPassedScreen()
    {
        StartCoroutine(showScreen());
        
    }

    IEnumerator showScreen()
    {
        levelPassed.SetActive(true);
        yield return new WaitForSecondsRealtime(4.0f);
        levelPassed.SetActive(false);
    }
}
