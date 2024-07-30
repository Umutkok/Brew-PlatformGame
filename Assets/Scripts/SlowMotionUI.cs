using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlowMotionUI : MonoBehaviour
{
    public Slider SlowMotionBar;
    public float FillSpeed = 0.3f;  // Barýn dolma hýzý
    public float slowMotionFactor = 0.5f;

    private bool isSlowingTime = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            isSlowingTime = true;
        }

        if (Input.GetKey(KeyCode.Y) && SlowMotionBar.value > 0.002f && isSlowingTime)
        {
            ZamanBariniAzalt();
            Time.timeScale = slowMotionFactor;
        }
        else
        {
            isSlowingTime = false;
            Time.timeScale = 1f;
            ZamanBariniArttir();
        }

        if (!isSlowingTime)
        {
            // Burada zaman yavaþlamýyorsa ve bar dolma sürecindeyse barý doldur
            SlowMotionBar.value = Mathf.MoveTowards(SlowMotionBar.value, 1f, FillSpeed * Time.deltaTime);
        }
    }

    void ZamanBariniAzalt()
    {
        SlowMotionBar.value -= FillSpeed * Time.deltaTime;
    }

    void ZamanBariniArttir()
    {
        SlowMotionBar.value += FillSpeed * Time.deltaTime;
    }
}
