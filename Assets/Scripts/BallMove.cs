using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public float force;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            rb.velocity = Time.deltaTime * force * Vector3.up;
        if (Input.GetKey(KeyCode.A))
            rb.velocity = Time.deltaTime * force * Vector3.left;
        if (Input.GetKey(KeyCode.D))
            rb.velocity = Time.deltaTime * force * Vector3.right;
    }
}
