using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelPassed : MonoBehaviour
{
    [SerializeField] GameObject levelPassed;

    public void levelPassedScreen(int sceneID)
    {
        levelPassed.SetActive(true);
        
    }
}
