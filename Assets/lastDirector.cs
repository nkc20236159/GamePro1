using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class LastDirector : MonoBehaviour
{
    GameObject nagai;
    // Start is called before the first frame update
    void Start()
    {
        this.nagai = GameObject.Find("tamesi");
        int m_FillAmount = 1;
        if(m_FillAmount == 0)
        {
            Debug.Log("owari");
            SceneManager.LoadScene("TitleScene");
        }
    }
    private void Update()
    {
        
    }

}
