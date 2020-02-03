using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        int test = 7;
        int testdoubled = Double(test);
        Debug.Log(Double(test));
        Debug.Log(testdoubled);

        test = OneOrZero("One");
    }

    // Update is called once per frame
    void Update()
    {
        //basic score increase vvvv
    //    if(Input.GetKeyDown(KeyCode.Space)){
    //        IncreaseScore();
      // } 
    }
//void doesn't return anything here, but still executes the code when it is called
//declares argument only in this function
//having return type of boolean checks if something actually ran
//public void IncreaseScore(int increaseAmt){

    //this function increases da score
    
    ///<summary>
    ///increases score by amount passed
    ///</summary>
    public bool IncreaseScore(int increaseAmt) {
        if(increaseAmt > 0){
        Debug.Log("Increasing Score");
        score++;
        return true;
    } else{
        return false;
        }
    }
    
    
    ///
    int Double(int todouble){
        return todouble*2;
    }

    int OneOrZero(string thingtoreturn){
        if(thingtoreturn == "One"){
            return 1;
            }else{
                return 0;
            }
        }

      public int CheatMode(string cheatCode){
          if(cheatCode == "Up, Down, Left"){
           Debug.Log("Cheat Activated");
           //to do: actually activate cheats
               return 1;
          }else{
              return 0;
          }
      } 
}