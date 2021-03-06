using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private bool ballMode; //false if ball is attached to platofrm, true if ball is in play
    private Vector3 ballPos;
    private Vector2 ballInitialVector;
    private Rigidbody2D rb2D;
    private TrailRenderer trail;
    public GameObject platformObject;
    [SerializeField] public float deathZone;

    public AudioClip hitTick;
    public AudioClip temp;
    AudioSource audioSource;

    private void Awake()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        trail = gameObject.GetComponent<TrailRenderer>();
    }


    // Start is called before the first frame update
    void Start()
    {
        //Create initial force
        ballInitialVector = new Vector2(400.0f, 800.0f);

        ballMode = false;

        ballPos = transform.position;

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        ApplyBallForce();

        //Attach ball to platform while inactive
        if (!ballMode && platformObject != null)
        {
            ballPos.x = platformObject.transform.position.x;

            transform.position = ballPos;
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            rb2D.AddForce(ballInitialVector);
        }

        ResetOnDeath();
    }

    private void ApplyBallForce()
    {
        //Inital force to start the game
        if (Input.GetButtonDown("Jump") == true)
        {
            if (!ballMode)
            {
                rb2D.AddForce(ballInitialVector);
                ballMode = !ballMode;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (ballMode)
        {
            audioSource.PlayOneShot(hitTick, 0.5f);
        }
    }

    public void ResetOnDeath()
    {
        //Reset the ball when the player dies :(
        if (ballMode && transform.position.y < deathZone)
        {
            trail.enabled = false;
            ballMode = !ballMode;
            ballPos.x = platformObject.transform.position.x;
            ballPos.y = -6.924f; //arbitrary starting value for the ball
            transform.position = ballPos;
            rb2D.velocity = Vector3.zero;
            trail.enabled = true;
            platformObject.SendMessage("LoseLife");
        }
    }
}
