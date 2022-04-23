using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private Rigidbody2D rb2D;

    private void Awake()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        transform.position -= transform.up * Time.deltaTime * 5;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject.FindGameObjectWithTag("Player").transform.localScale += new Vector3(0.2F, 0, 0);
        Destroy(this.gameObject);
    }
}
