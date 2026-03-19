using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public Health playerHealth;
    public CoinsCounter playerCoin;
    public TextMeshProUGUI coinsCounterText;
    public Slider healthSlider;


    // Update is called once per frame
    void Update()
    {
        //Обновлять значение здоровья игрока
        healthSlider.maxValue = playerHealth.maxHealth;
        healthSlider.value = playerHealth.health;

        //Обновлем текст с кол-вом монеток
        coinsCounterText.text = playerCoin.coins.ToString();
    }
}
