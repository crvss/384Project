using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBrick : MonoBehaviour
{
    [SerializeField] GameObject powerUp;

    public void onBreak()
    {
        powerUp.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
