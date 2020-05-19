using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this is for more realistic movement
public class Cont2 : MonoBehaviour
{
    public float moveSpeed2;

    //public float jumpSpeed2;

    private Rigidbody rb;
    public bool cubeIsOnGround = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * moveSpeed2);

          if(Input.GetButtonDown("Jump") && cubeIsOnGround){
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            cubeIsOnGround = false;
         }
    }

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Floor") {
            cubeIsOnGround = true;
        }
    }
}
