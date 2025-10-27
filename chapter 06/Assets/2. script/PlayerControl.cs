using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce = 60f;
    public float walkForce = 30f;
    public float maxwalkspeed = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpForce);
        }

        int key = 0;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;

        float speedX = Mathf.Abs(rb.velocity.x);
        if (speedX < maxwalkspeed)
        {
            rb.AddForce(transform.right * key * walkForce);
        }


        if(key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }
    }

}
