using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        CoinsCounter playerCoins = other.GetComponent<CoinsCounter>();
        playerCoins.CollectCoins();

        Destroy(gameObject);
    }
}
