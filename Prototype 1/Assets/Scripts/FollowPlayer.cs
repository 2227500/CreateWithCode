using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Initializing Variables
    public GameObject player; // Getting a game object in unity
    private Vector3 offset = new Vector3(0, 5.34f, -6.47f); // for the camera
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate() // to smoothen the camera movement

    {   // set this script's object position to the postion of the game object above
        // set the camera behind the player by adding tho the players position
        transform.position = player.transform.position + offset; 
   
    }
}
