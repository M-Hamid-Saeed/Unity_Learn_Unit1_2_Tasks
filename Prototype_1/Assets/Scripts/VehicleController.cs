using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocity;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;
    void Start()
    {
        
    }
    public Rigidbody rb;
    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * velocity * forwardInput);
        transform.Rotate(Vector3.up,  Time.deltaTime * turnSpeed * horizontalInput);
        
    }
}
