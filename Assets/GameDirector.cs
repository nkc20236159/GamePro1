using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.VisualScripting;

public class GameDirector : MonoBehaviour
{
    GameObject Time_gauge;
    
    GameObject Timersa;

    
     
    void Start()
    {
        this.Time_gauge = GameObject.Find("Time_gauge");
        
        this.Timersa = GameObject.Find("Time_gauge");
    }

    void Update()
    {
        
        
        this.Timersa.GetComponent<Image>().fillAmount -= 0.0002f;

    }

    public void DecreaseHp()
    {
        
        this.Time_gauge.GetComponent<Image>().fillAmount -= 0.1f;

    }
    
}
