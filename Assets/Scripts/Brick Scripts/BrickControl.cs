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
                Destroy(this.gameObject);
            }
        }
    }
}
