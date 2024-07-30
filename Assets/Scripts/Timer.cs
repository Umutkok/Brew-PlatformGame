using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Image Timerasset;
    public static float timeleft;
    public static float maxTime = 800f;

    public Transform firepoint;
    public GameObject bullet;

    PlayerCollision need;
    void Start()
    {
        timeleft = maxTime;
        need = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCollision>();
    }

  
    void Update()
    {
        if (timeleft > 0)
        {
            timeleft -= Time.deltaTime;
            Timerasset.fillAmount = timeleft / maxTime;
        }
        else
        {
            Instantiate(bullet, firepoint.position, firepoint.rotation);    //Karakterin içine mermi spawn layarak bir çözüm buldum
            //Timeup();
            timeleft = maxTime;
        }



    }

    //public void Timeup()
    //{
        
        
    //   HealthManager.health--;
    //   need.Die();
       
        
    //}



}
