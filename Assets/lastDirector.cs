using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class LastDirector : MonoBehaviour
{
    GameObject nagai;
    float m_FillAmount;
    GameObject Time_gauge;
    GameObject timerText;
    float time = 100.0f;
    void Start()
    {
        Application.targetFrameRate = 60;
        this.nagai = GameObject.Find("tamesi");
        this.Time_gauge = GameObject.Find("Time_gauge");
        this.timerText = GameObject.Find("time");
    }
    void Update()
    {
        this.time -= Time.deltaTime;
        this.timerText.GetComponent<TextMeshProUGUI>().text = this.time.ToString("F1");
        transform.Translate(0, 0, 0);
        if (time <= 0)
        {
            Debug.Log("owari");
            SceneManager.LoadScene("TitleScene");
        }
    }
    

    public void Translate()
    {
        this.nagai.transform.Translate(0, 0, 0);
        this.time -= 10.0f;


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("owari");
        SceneManager.LoadScene("TitleScene");
    }

}