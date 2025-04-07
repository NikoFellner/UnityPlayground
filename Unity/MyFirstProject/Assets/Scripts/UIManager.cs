using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Image _shootCDImg;
    public TMPro.TextMeshProUGUI _scoreTimeTxt;
    void Update()
    {      
        _scoreTimeTxt.text = "Time: " + Time.time.ToString("00:00");
    }

    public void UpdateShootCD(float readyness)
    {
        print(readyness);
        _shootCDImg.fillAmount = readyness;
    }

    public void GameSpeedChanged(float speed)
    {
        Time.timeScale = speed;
    }
     
}
