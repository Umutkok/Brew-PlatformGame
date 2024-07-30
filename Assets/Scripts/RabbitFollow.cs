using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitFollow : MonoBehaviour
{
    private Transform targetPlayer;
    public float rabbitspeed;
    public float distance;
    public float jumpForce;
    Rigidbody2D rb;

    void Start()
    {
        targetPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Vector2.Distance(transform.position, targetPlayer.position) >= distance)
        {
            transform.position = Vector2.MoveTowards(transform.position,targetPlayer.position, Time.deltaTime*rabbitspeed);
        }

        if (transform.position.x < targetPlayer.position.x)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        rb.AddForce(Vector2.up*Time.deltaTime*jumpForce);

       
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }


}
