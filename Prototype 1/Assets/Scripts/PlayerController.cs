using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //initializing variables
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Code to move to vehicle.
        transform.Translate(Vector3.forward * Time.deltaTime * speed); //vector3.forward = 0, 0, 1 : Vector3 = 0, 0, 0
    }
}
