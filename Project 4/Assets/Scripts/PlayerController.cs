using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this is for unrealistic movement
public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    //public float jumpSpeed;
    private Rigidbody rb;
    public bool cubeIsOnGround = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //moving
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * moveSpeed);

            //jumping
         if(Input.GetButtonDown("Jump") && cubeIsOnGround){
            rb.AddForce(new Vector3(0, 20, 0), ForceMode.Impulse);
            cubeIsOnGround = false;
         }
    }

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Floor") {
            cubeIsOnGround = true;
        }
    }

}
