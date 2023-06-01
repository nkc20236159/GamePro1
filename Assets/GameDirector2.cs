using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class GameDirector2 : MonoBehaviour
{
    Text textComponent;
    float time = 1000000;
    GameObject TimerText;
    // Start is called before the first frame update
    void Start()
    {
        textComponent = GetComponent<Text>();
        this.TimerText = GameObject.Find("kyori");
    }

    // Update is called once per frame
    void Update()
    {
        this.time += 000001f;
        textComponent.text += "km";
        this.TimerText.GetComponent<Text>().text = this.time.ToString();
    }
   
}
