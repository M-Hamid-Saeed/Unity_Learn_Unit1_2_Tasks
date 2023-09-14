using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsMoving : MonoBehaviour
{

    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * 20);
    }
    
}
