using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameDirector : MonoBehaviour
{
    GameObject Time_gauge;
    GameObject TimerText;
    float time = 0000000f;
    void Start()
    {
        this.Time_gauge = GameObject.Find("Time_gauge");
        this.TimerText = GameObject.Find("kyori");
    }

    void Update()
    {
        this.time += 000001;
        this.TimerText.GetComponent<TextMeshProUGUI>().text = this.time.ToString();
    }

    public void DecreaseHp()
    {
        
        
    }
}
