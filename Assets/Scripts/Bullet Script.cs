using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private GameObject Shootingat; // vurulmasýný istediðimiz obje
    private Rigidbody2D rb;

    public float bulletspeed;
    private float timer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Shootingat = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = Shootingat.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * bulletspeed;

        float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot);                   // rot deðiþkeninin yanýna + ile derece ekliyerek mermiyi döndür
    }

   
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 10)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);   
        }

        if (other.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }



}
