using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotion : MonoBehaviour
{
    public float slowMotionFactor = 0.5f;

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Y)) 
        {
            Time.timeScale = slowMotionFactor;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }




}
