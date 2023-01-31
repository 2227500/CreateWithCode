using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //initializing variables
    public float speed = 5.0f;
    public float turnSpeed = 3.0f;
    public float horizontalInput;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Code to move the vehicle.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput); //vector3.forward = 0, 0, 1 : Vector3 = 0, 0, 0
        
        // Code to move the vehicle left / right... added horizontal input to let it accept input
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
