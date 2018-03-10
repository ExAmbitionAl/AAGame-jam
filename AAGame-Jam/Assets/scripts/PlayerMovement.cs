using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    Rigidbody rb;
    float h, v;
    public float speed = 1f;



    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        rb.transform.Translate(new Vector3(h * speed, 0, v * speed) * Time.deltaTime);

    }

    void playerRotate()
    {

    }
}
