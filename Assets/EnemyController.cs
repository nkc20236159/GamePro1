using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyController : MonoBehaviour
{
    GameObject MyChar_0;
    private void Start()
    {
        this.MyChar_0 = GameObject.Find("MyChar_0");
    }

    void Update()
    {
        transform.Translate(-0.1f, 0, 0);
        if (transform.position.x < -11.0f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.MyChar_0.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;
        if (d < r1 + r2)
        {
            Destroy (gameObject);
        }

    }
    
}
