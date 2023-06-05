using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody2D>().AddForce(dir);
    }

    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
        GetComponent<Rigidbody2D>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
    }
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        //Shoot(new Vector3(0, 200, 2000));
    }
}