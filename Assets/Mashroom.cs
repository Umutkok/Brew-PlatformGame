using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mashroom : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {


        if (HealthManager.health < 5)
        {
                if (other.CompareTag("Player"))
                {
                    HealthManager.health++;
                    Destroy(gameObject);
                }
        }
        else
        {
         Physics2D.IgnoreLayerCollision(6, 10);
        }


    }
}
