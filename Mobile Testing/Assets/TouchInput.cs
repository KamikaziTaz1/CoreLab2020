using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{

    public FXController FXMan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < Input.touchCount; i++){
            Touch thisTouch = Input.GetTouch(i);//picks up whenever you touch the screen


            if(thisTouch.phase == TouchPhase.Ended && thisTouch.tapCount == 1){
                FXMan.SpawnExplosion(Camera.main.ScreenToWorldPoint(thisTouch.position));
            }
        }
       //input.touches functions similar to Input.GetButtonDown 
    }
}
