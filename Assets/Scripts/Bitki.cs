using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bitki : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;

    private float timer;
    public float distancePlayer;

    private GameObject shootingat;


    public Animator BitkiAnimation;

    void Start()
    {
        shootingat = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        
        float distance = Vector2.Distance(transform.position, shootingat.transform.position);
        //Debug.Log(distance);
        if(distance < distancePlayer)
        {
            
            timer += Time.deltaTime;
            //BitkiAnimation.SetBool("fire", true);

            if (timer > 2)
            {
                timer = 0;
                shoot();
            }
        }

        void shoot()
        {
            Instantiate(bullet, bulletPos.position, Quaternion.identity); //Spawn olmasýný saðlýyor
        }




    }
}
