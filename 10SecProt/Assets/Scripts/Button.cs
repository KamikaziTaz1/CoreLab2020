using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject buttonOn;

    public  GameObject buttonOff;

    public GameObject door;

    public GameObject doorSlide;

    public SpriteRenderer sr;

    public bool isOn = false;
    public bool doorOpen = false;


    

     void Start()
    {
        

    }

     void OnTriggerEnter2D(Collider2D other)
    {
        //set sprite to on
        if(other.gameObject.tag == "Player")
        {
            sr.color = Color.green;

            Invoke("HitByPlayer", 1f);

        }
       
        

    }

    void HitByPlayer()
    {
        sr.color = Color.green;
        isOn = true;
        doorOpen = true;
        Destroy(door, 2f);
        doorSlide.SetActive(true);
        Debug.Log("Button Pressed");

    }


}
