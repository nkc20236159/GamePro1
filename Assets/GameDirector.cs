using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.VisualScripting;
using TMPro;

public class GameDirector : MonoBehaviour
{
    GameObject Time_gauge;
    
    GameObject Timersa;
    GameObject timerText;
    //float time = 60.0f;
    
     
    void Start()
    {
        this.Time_gauge = GameObject.Find("Time_gauge");
        this.Timersa = GameObject.Find("Time_gauge");
        Application.targetFrameRate = 60;
    }

    void Update()
    {


        this.Timersa.GetComponent<Image>().fillAmount -= 0.000166f;
    }

    public void DecreaseHp()
    {
        
        this.Time_gauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
