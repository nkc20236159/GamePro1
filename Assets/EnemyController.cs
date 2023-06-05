using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyController : MonoBehaviour
{
    GameObject Player;
    private void Start()
    {
        this.Player = GameObject.Find("Player");
    }

    void Update()
    {
        transform.Translate(-0.1f, 0, 0);
        if (transform.position.x < -11.0f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.Player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 0.6f;
        if (d < r1 + r2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();
            
            Destroy (gameObject);

            GameObject director2 = GameObject.Find("tamesi");
            director2.GetComponent<LastDirector>().Translate();

        }

    }
    
}
