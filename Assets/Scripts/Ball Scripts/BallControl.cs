using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private bool ballMode; //false if ball is attached to platofrm, true if ball is in play
    private Vector3 ballPos;
    private Vector2 ballInitialVector;
    private Rigidbody2D rb2D;
    public GameObject platformObject;
    [SerializeField] public float deathZone;

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
                rb2D.isKinematic = false; //reset force on ball
                rb2D.AddForce(ballInitialVector);
                ballMode = !ballMode;
            }
        }

        //Attach ball to platform while inactive
        if (!ballMode && platformObject != null)
        {
            ballPos.x = platformObject.transform.position.x;

            transform.position = ballPos;
        }

        //Reset the ball when the player dies :(
        if (ballMode && transform.position.y < deathZone)
        {
            ballMode = !ballMode;
            ballPos.x = platformObject.transform.position.x;
            ballPos.y = -6.926f; //arbitrary starting value for the ball
            transform.position = ballPos;

            rb2D.isKinematic = true;
        }
    }
}
