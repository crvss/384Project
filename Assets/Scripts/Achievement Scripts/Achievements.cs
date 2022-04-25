using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievements : MonoBehaviour
{
    public GameObject achievePanel;
    public AudioSource achieveSound;

    public bool achieveActive = false;

    public GameObject acieveBrickBreakerTitle;
    public GameObject achieveBrickBreakerDesc;
    public GameObject achieveBrickBreakerImage;
    public static int achieveBrickBreakerNumber;
    public int achieveBrickBreakerTrigger = 20;
    public int achieveBrickBreakerCode;

    void Update()
    {
        
    }
}
