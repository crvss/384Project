using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    [SerializeField] private float Speed = 20f;
    public float gameBounds;
    private Vector3 playerPos;

    // Start is called before the first frame update
    void Start()
    {
        playerPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Horizontal movement
        float hSpeed = Input.GetAxis("Horizontal") * Speed;
        this.transform.Translate(hSpeed * Time.deltaTime, 0, 0); //use time to move player on seconds

        //Update player position
        playerPos = this.transform.position;

        //Prevent platform from moving outside game bounds
        if (playerPos.x < -gameBounds)
        {
            transform.position = new Vector3(-gameBounds, playerPos.y, playerPos.z);
        }
        if (playerPos.x > gameBounds)
        {
            transform.position = new Vector3(gameBounds, playerPos.y, playerPos.z);
        }
    }
}
