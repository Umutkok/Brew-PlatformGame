using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public static int health = 3;
    public Image[] hearts;

    public Sprite fullHearth;
    public Sprite emptyHearth;

    //private void Awake()
    //{
    //    health = 3;
    //}


    void Update()
    {
        foreach (Image img in hearts)
        {
            img.sprite = emptyHearth;
        }
        for (int i = 0; i < health ; i++)
        {
            hearts[i].sprite = fullHearth;
        }



        if (health > 5)
        {
            health = 5;
        }
    }
}
