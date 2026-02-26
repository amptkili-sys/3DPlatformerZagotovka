using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private int health = 10;

    public GameObject fireballPrefab;
    public Transform attackPoint;
    int coins;

    public AudioSource audioSource;
    public AudioClip damageSound;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
    // Метод, понижающий здоровье
    public void TakeDamage(int damage)
    {
        print("Здоровье игрока" + health);
        health -= damage;
        if (health > 0)
        {
            print("Здоровье игрока" + health);
            audioSource.PlayOneShot(damageSound);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }

        
    }

    public void CollectCoins()
    {
        coins++;
        Debug.Log("Coins: " + coins);
    }
}
