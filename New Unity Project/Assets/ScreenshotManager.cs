using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenshotManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void CaptureScreenshot() {
        string path = Application.dataPath;
        // Debug.Log(path);
        // Debug.Log(Application.dataPath);
        ScreenCapture.CaptureScreenshot(path + "/" + "testScreen" + System.DateTime.Now.ToString("MM-dd-yyyy_hh-mm") + ".png");
    }
}
