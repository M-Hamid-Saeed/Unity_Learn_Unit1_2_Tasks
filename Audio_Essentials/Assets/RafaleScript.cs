using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RafaleScript : MonoBehaviour
{ public Vector3 rafalePos;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += rafalePos;
    }
}
