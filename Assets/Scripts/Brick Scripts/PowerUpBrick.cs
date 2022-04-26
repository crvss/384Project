using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBrick : MonoBehaviour
{
    [SerializeField] GameObject powerUp;

    public void OnBreak()
    {
        powerUp.SetActive(true);
    }
}
