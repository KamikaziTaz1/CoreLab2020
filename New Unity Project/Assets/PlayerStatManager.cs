using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; //IO stands for In-Out; handles data extraction

public class PlayerStatManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SaveSomeData();
    }

    bool hasloggeddata = false;
    // Update is called once per frame
    void Update()
    {
        if(Time.time > 3f && !hasloggeddata){
            hasloggeddata = true;
            SaveSomeData("Timeplayed =" + Time.time.ToString());//this whole function uploads play time after 3 seconds
        }
    }

    StreamWriter sw;//this will write the text
    void SaveSomeData(){
        sw = new StreamWriter(Application.dataPath + "/datatest.txt");
        sw.Write("I'm writing to a text file");
        sw.Close();//you have to close the stream otherwise there could be a memory leak
    }
}
