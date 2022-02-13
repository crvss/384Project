using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    [SerializeField] private float Speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hSpeed = Input.GetAxis("Horizontal") * Speed;

        this.transform.Translate(hSpeed * Time.deltaTime, 0, 0); //use time to move player on seconds
    }
}
