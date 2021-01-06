using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody r3D;
    float jumpower = 0;
    bool jumped = false;
    float myYpos;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        myYpos = transform.position.y;
        r3D = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        

        if(Input.GetKey(KeyCode.D)){
            transform.Translate(0,0,0.3f);
        } if (Input.GetKey(KeyCode.A)){
            transform.Translate(0,0,-0.3f);
        } if (Input.GetKey(KeyCode.W)){
            transform.Translate(-0.3f,0,0);
        } if (Input.GetKey(KeyCode.S)){
            transform.Translate(0.3f,0,0);

        } if ( Input.GetKeyDown(KeyCode.Space) && player.position ){
            
            r3D.AddForce(transform.up * 480);

        }

        

    }
}
