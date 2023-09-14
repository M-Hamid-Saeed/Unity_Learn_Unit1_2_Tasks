using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSwitch : MonoBehaviour
{
    //public Camera[] cameras;         // Array of cameras to switch between
    //private int currentCameraIndex = 0;
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.C))
    //    {
    //        // Disable the current camera
    //        cameras[currentCameraIndex].gameObject.SetActive(false);

    //        // Increment the camera index
    //        currentCameraIndex++;
    //        if (currentCameraIndex >= cameras.Length)
    //        {
    //            currentCameraIndex = 0;
    //        }

    //        // Enable the new current camera
    //        cameras[currentCameraIndex].gameObject.SetActive(true);
    //    }

    //}
    public Transform driverSeat;
    public Transform outerView;
    public GameObject player;
    public Vector3 driverseatoffset;
    public Vector3 mainCameraOffset;
   

    private Transform currentCamera;

    private void Start()
    {
        // Set the initial active camera
        currentCamera = outerView;
        driverSeat.gameObject.SetActive(false);
        outerView.gameObject.SetActive(true);
    }

    private void LateUpdate()
    {
        // Toggle between cameras based on player input
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Switch cameras
            if (currentCamera == driverSeat)
            {
                currentCamera.gameObject.SetActive(false);
                currentCamera = outerView;
                currentCamera.gameObject.SetActive(true);
            }
            else
            {
                currentCamera.gameObject.SetActive(false);
                currentCamera = driverSeat;
                currentCamera.gameObject.SetActive(true);
            }
        }
        if (currentCamera == driverSeat)
        {
            currentCamera.position = player.transform.position + driverseatoffset;
            currentCamera.rotation = player.transform.rotation;
        }
        else
        {
            currentCamera.position = player.transform.position + mainCameraOffset;
        }
      
        
        
    }
    
}


