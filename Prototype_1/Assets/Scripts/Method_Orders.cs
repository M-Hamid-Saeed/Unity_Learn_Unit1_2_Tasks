using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method_Orders : MonoBehaviour
{
    bool continueUpdate = true;
    bool continueFixedUpdate = true;
    bool continueLateUpdate = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }
    // Awake is called when the object is enabled
    void Awake()
    {
        Debug.Log("Awake");
    }

    //FixedUpdate is called before Update, at the same rate based on Delta Time
    void FixedUpdate()
    {
        if (continueFixedUpdate)
        {
            Debug.Log("Fixed Update");
            //continueFixedUpdate = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (continueUpdate)
        {
            Debug.Log("Update");
            //continueUpdate = false;
        }
    }
    //Late Update is called after update
    void LateUpdate()
    {
        if (continueLateUpdate)
        {
            Debug.Log("Late Update");
            //continueLateUpdate = false;
        }
    }
}
