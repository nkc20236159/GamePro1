using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject Enemy_0Pre;
    float span = 1.0f;
    float delta = 0;
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(Enemy_0Pre);
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(15, px, 0);
        }
    }
}
