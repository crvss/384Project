using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private bool ballMode; //false if ball is attached to platofrm, true if ball is in play
    private Vector3 ballPos;
    private Vector2 ballInitialVector;

    // Start is called before the first frame update
    void Start()
    {
        //Create initial force
        ballInitialVector = new Vector2(10.0f, 30.0f);

        ballMode = false;

        ballPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") == true) 
        {
            if (!ballMode)
            {
                //Rigidbody2D.AddForce(ballInitialVector);

                ballMode = !!ballMode;
            }
        }
    }
}
