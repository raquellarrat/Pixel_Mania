using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float bulletSpeed = 20f;
    Rigidbody2D myRigidbody;
    PlayerMovement player;
    float xSpeed;
    
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        player = FindFirstObjectByType<PlayerMovement>();
        xSpeed = player.transform.localScale.x * bulletSpeed; // guarda a direcao e a velocidade que a bala irá
    }

    void Update()
    {
        myRigidbody.velocity = new Vector2 (xSpeed, 0f);  // garante que a bala se movimente apenas horizontalmente
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Enemy")
        {
            Destroy(other.gameObject);  // destroi o inimigo
        }
        Destroy(gameObject); // destroi a bala
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Destroy(gameObject); //destroi a bala ao se colidir   
    }

}
