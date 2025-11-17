using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    public int forwardForece = 2000;
    public int upForce = 800;

    // Start is called before the first frame update


    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
    }



    void Start()
    {
        Application.targetFrameRate = 60;
        //Shoot(new Vector3(0, upForce, forwardForece));
       // Shoot(new Vector3(0, 200, 200));
    }
}
