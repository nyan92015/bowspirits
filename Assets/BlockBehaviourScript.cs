using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject Block;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Material mat = this.GetComponent<Renderer>().material;
            mat.color = Color.grey;
            Invoke("onGravity", 0.4f);
            Destroy(Block, 2f);
        }
    }
    void onGravity()
    {
        rb.isKinematic = false;
    }
}