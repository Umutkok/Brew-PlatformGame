using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject door;

    public static int collectedSymbols = 0;

    public TextMeshProUGUI text;
    


 
    void Update()
    {
        text.text = "Axe: " + collectedSymbols + " /4";

        if (collectedSymbols == 4)
        {
            door.SetActive(false);
        }
    }
}
