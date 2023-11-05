using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip coinPickupSFX;
    [SerializeField] int pointsForCoinPickup = 100;
    
    bool wasCollected = false;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player" && !wasCollected)
        {
            wasCollected = true;
            FindFirstObjectByType<GameSession>().AddToScore(pointsForCoinPickup); // adiciona pontos
            AudioSource.PlayClipAtPoint(coinPickupSFX, Camera.main.transform.position); // tocar o som de coin pickup na posicao da camera
            gameObject.SetActive(false);
            Destroy(gameObject); // destroi o coin
        }
    }
}
