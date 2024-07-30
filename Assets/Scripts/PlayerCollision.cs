using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public Transform spawnpoint;
    public Animator animator;
    private Rigidbody2D rb;

    public bool DeadCheck;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            Die();
            HealthManager.health--;

            Timer.timeleft = Timer.maxTime;

            if (HealthManager.health <= 0)
            {
                
                StartCoroutine(GetHurt(0.8f));
                StartCoroutine(GameOverDelay(0.8f));
                
            }
            else
            {
                
                StartCoroutine(GetHurt(0.8f));
                StartCoroutine(RespawnAfterDelay(0.8f));
                
            }
        }

        if (collision.transform.tag == "Axe")
        {
            GameManager.collectedSymbols++;
            Debug.Log("Simge Toplandý. Toplanan Simgeler: ");

            Destroy(collision.gameObject);
        }


    }



    IEnumerator RespawnAfterDelay(float delay)
    {
        
        yield return new WaitForSeconds(delay);
        Respawn();
    }
    IEnumerator GameOverDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("GameOverScreen");
    }
    IEnumerator GetHurt(float süre)
    {
        Physics2D.IgnoreLayerCollision(7, 9);
        yield return new WaitForSeconds(süre);
        Physics2D.IgnoreLayerCollision(7, 9, false);
    }

    public void Respawn()
    {
        DeadCheck = false;
        animator.SetTrigger("Die");

        this.transform.position = spawnpoint.position;                            // Spawn point ile yapmaktansa scene manager ile ayný sahneyi yeniden yükledim
        rb.bodyType = RigidbodyType2D.Dynamic;                                     // Bu sayede karakter öldüðünde dead animasyonu takýlý kalmýyor
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void Die()
    {
        DeadCheck= true;
        animator.SetTrigger("Die");
        Debug.Log("I'm finaly working!");
        rb.bodyType = RigidbodyType2D.Static; 
    }



}
