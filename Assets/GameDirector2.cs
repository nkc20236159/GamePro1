using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameDirector2 : MonoBehaviour
{
    Text textComponent;
    float time = 0000001;
    GameObject TimerText;
    // Start is called before the first frame update
    void Start()
    {
        
        this.TimerText = GameObject.Find("kyori");
    }

    // Update is called once per frame
    void Update()
    {
        this.time += 000001f;
        textComponent.text = "km";
        this.TimerText.GetComponent<TextMeshProUGUI>().text = this.time.ToString();
    }
}
