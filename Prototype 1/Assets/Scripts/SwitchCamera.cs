using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public Camera mainCam;
    public Camera driverCam;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            mainCam.enabled = !mainCam.enabled;
            driverCam.enabled = !driverCam.enabled;

        }
    }
}
