using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;

    public TextMeshProUGUI textTimer;

    // Цикл обновления составляет примерно 0.01 секунды
    void Update()
    {
        seconds -= Time.deltaTime;

        if (seconds <= 0)
        {
            if (minutes > 0)
            {
                seconds += 59;

                minutes--;
            }
            else
            {
                // Если таймер остановился, перезагружаем текущую сцену
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }
        }
        int roundSecond = Mathf.RoundToInt(seconds);
        textTimer.text = minutes + ":" + roundSecond;
    }
}
