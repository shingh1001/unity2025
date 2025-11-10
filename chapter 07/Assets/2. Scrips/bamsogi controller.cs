using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bamsogicontroller : MonoBehaviour
{
    public int forwardForece = 2000;
    public int upForce = 800;
    
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        //Shoot(new Vector3(0, upForce, forwardForece));
        Destroy(gameObject, 10);
    }

    void Shoot(Vector3 dir){
        GetComponent<Rigidbody>().AddForce(dir);
    }
}
