using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class GameDirector2 : MonoBehaviour
{
    Text textComponent;
    float time = 000000;
    GameObject TimerText;
    
    void Start()
    {
        textComponent = GetComponent<Text>();
        this.TimerText = GameObject.Find("kyori");
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        this.time += 1f;
        textComponent.text += "km";
        this.TimerText.GetComponent<Text>().text = this.time.ToString("000000km");
    }
   
}
