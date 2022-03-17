using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBallControl : MonoBehaviour
{
    private double val;
    private Rigidbody2D rb2D;
    private Vector2 ballInitialVector;


    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        ballInitialVector = new Vector2(randFloat(), -randFloat());
        rb2D.AddForce(ballInitialVector);
    }


    void Update()
    {
        
    }

    private float randFloat()
    {
        val = 0;
        System.Random rand = new System.Random();
        val = (rand.NextDouble() * (600.0f - 300.0f) + 300.0f);
        return (float)val;
    }
}
