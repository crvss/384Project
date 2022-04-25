using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickControl : MonoBehaviour
{
    public int brickHP;
    private int brickDamageTaken;
    public int pointsToGive;

    // Start is called before the first frame update
    void Start()
    {
        brickDamageTaken = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            brickDamageTaken++;

            if (brickDamageTaken == brickHP)
            {
                GameObject platform = GameObject.FindGameObjectsWithTag("Player")[0];

                platform.SendMessage("addPoints", pointsToGive);

                if (this.gameObject.tag == "PowerUp")
                {
                    GameObject powerUp = GameObject.FindGameObjectsWithTag("PowerUp")[0];
                    powerUp.SendMessage("onBreak");
                }
                Achievements.achieveBBNumber += 1;
                Destroy(this.gameObject);
            }
        }
        
    }
}
