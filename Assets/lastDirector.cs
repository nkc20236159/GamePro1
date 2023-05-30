using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class lastDirector : MonoBehaviour
{
    GameObject nagai;
    // Start is called before the first frame update
    void Start()
    {
        this.nagai = GameObject.Find("tamesi");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(1, 0, 0);



    }

    public void DecreaseHp()
    {
        this.nagai.transform.Translate(600, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("owari");
        SceneManager.LoadScene("TitleScene");
    }
}
