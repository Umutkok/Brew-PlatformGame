using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrol : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    public float cameraX;
    public float cameraY;

    public float normalSize = 5f;
    public float zoomedOutSize = 6f;

    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(cameraX, cameraY, -10);
    }
    
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
