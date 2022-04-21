using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformController : MonoBehaviour
{
    [SerializeField] private float Speed = 20f;
    public float gameBounds;
    private Vector3 platformPos;

    private string playerName;
    private int score;
    private int lives;

    private GUIStyle guiStyle = new GUIStyle();

    AudioSource audioSource;
    public AudioClip pointTick;
    public AudioClip lifeDown;

    private static int LevelNumber = 1;


    // Start is called before the first frame update
    void Start()
    {
        platformPos = gameObject.transform.position;
        score = 0;
        lives = 3;

        audioSource = GetComponent<AudioSource>();

        PlayerData.playerName = playerName;
        PlayerData.score = score;
        PlayerData.level = LevelNumber;
    }

    // Update is called once per frame
    void Update()
    {
        //Horizontal movement
        float hSpeed = Input.GetAxis("Horizontal") * Speed;
        this.transform.Translate(hSpeed * Time.deltaTime, 0, 0); //use time to move player on seconds

        //Update player position
        platformPos = this.transform.position;

        boundaryRestrict();

        winState();
    }

    private void boundaryRestrict()
    {
        //Prevent platform from moving outside game bounds
        if (platformPos.x < -gameBounds)
        {
            transform.position = new Vector3(-gameBounds, platformPos.y, platformPos.z);
        }
        if (platformPos.x > gameBounds)
        {
            transform.position = new Vector3(gameBounds, platformPos.y, platformPos.z);
        }
    }

    public void addPoints(int points)
    {
        score += points;
        audioSource.PlayOneShot(pointTick, 0.5f);
    }

    void loseLife()
    {
        lives--;
        audioSource.PlayOneShot(lifeDown, 1.0f);
    }

    void winState()
    {
        GameObject platform = GameObject.FindGameObjectsWithTag("Player")[0];
        GameObject save = GameObject.FindGameObjectsWithTag("Save")[0];
        //Restart game if player loses
        if (lives == 0)
        {
            platform.SendMessage("playerDied");     
        }

        //Check to see if all blocks have been destroyed
        if (GameObject.FindGameObjectsWithTag("Bricks").Length == 0)
        {
            if (SceneManager.GetActiveScene().name.Equals("Level " + LevelNumber))
            {
                LevelNumber++;
                save.SendMessage("SaveData");
                platform.SendMessage("levelPassedScreen");
                SceneManager.LoadScene("Level " + LevelNumber);
            }
        }
    }

    private void OnGUI()
    {
        Font neonFont = (Font)Resources.Load("Fonts/Neon1", typeof(Font));

        guiStyle.font = neonFont;
        guiStyle.fontSize = 90;
        GUI.Label(new Rect(60.0f, 30.0f, 200.0f, 200.0f), "Lives: " + lives + "    Score: " + score, guiStyle);
    }
}
