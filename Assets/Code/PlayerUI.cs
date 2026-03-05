using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI coinsCounterText;
    public Slider healthSlider;


    // Update is called once per frame
    void Update()
    {
        //Обновлять значение здоровья игрока
        healthSlider.maxValue = player.maxHealth;
        healthSlider.value = player.health;

        //Обновлем текст с кол-вом монеток
        coinsCounterText.text = player.coins.ToString();
    }
}
