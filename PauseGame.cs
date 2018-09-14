using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour {
    
    public void TogglePause()

    {
        GameObject Snake = GameObject.FindWithTag("SnakeHead");

        // пример из инета как в одной строчке написать код попеременного изменения таймскела по нажатию кнопки
        //Time.timeScale = Mathf.Approximately(Time.timeScale, 0.0f) ? 1.0f : 0.0f;

        if (Time.timeScale != 0)
        {
            Snake.GetComponent<SnakeController>().k=0;
            Time.timeScale = 0;
        } else
        {
            Snake.GetComponent<SnakeController>().k = 1;
            Time.timeScale = 1;
        }
        

    }

}
