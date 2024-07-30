using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{


    
    public float normalSize = 5f;
    public float zoomedOutSize = 6f;

    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Y)) // Yerine kullanmak istediðiniz tuþu ekleyin
        {
            Camera.main.orthographicSize = zoomedOutSize;
        }
        else
        {
            Camera.main.orthographicSize = normalSize;
        }
    }
}
