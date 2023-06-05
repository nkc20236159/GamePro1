using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGenerator : MonoBehaviour
{
    public GameObject MyShot_0Prefab;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject MyShot =
                Instantiate(MyShot_0Prefab);
            MyShot.GetComponent<ShotController>().Shoot(new Vector3(0.05f,0,0));
        }
    }
}
