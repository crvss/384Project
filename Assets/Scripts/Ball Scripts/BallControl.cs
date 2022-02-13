using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private bool ballMode; //false if ball is attached to platofrm, true if ball is in play
    private Vector3 ballPos;
    private Vector2 ballInitialVector;
    private Rigidbody2D rb2D;
    public float gameBounds;

    private void Awake()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }


    // Start is called before the first frame update
    void Start()
    {
        //Create initial force
        ballInitialVector = new Vector2(200.0f, 400.0f);

        ballMode = false;

        ballPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Inital force to start the game
        if (Input.GetButtonDown("Jump") == true) 
        {
            if (!ballMode)
            {
                rb2D.AddForce(ballInitialVector);

                ballMode = !!ballMode;
            }
        }

        //Update player position
        ballPos = this.transform.position;

        //Prevent platform from moving outside game bounds
        if (ballPos.x < -gameBounds)
        {
            transform.position = new Vector3(-gameBounds, ballPos.y, ballPos.z);
        }
        if (ballPos.x > gameBounds)
        {
            transform.position = new Vector3(gameBounds, ballPos.y, ballPos.z);
        }
    }
}
