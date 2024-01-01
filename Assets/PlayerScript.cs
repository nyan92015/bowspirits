using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody rb;
    private int upForce;
    private bool onGround = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        upForce = 300;
    }

    // Update is called once per frame
    void Update()
    {
        Material mat = this.GetComponent<Renderer>().material;

        if (Input.GetKey(KeyCode.Space) && onGround)
        {
            mat.color = Color.red;
            rb.AddForce(new Vector3(0, upForce, 0));
            onGround = false;
        }
        else
        {
            mat.color = Color.white;
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "block")
        {
            onGround = true;
        }
    }
}
