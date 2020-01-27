using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    float currentTime = 0f;
    float startTime = 10f;

    [SerializeField] Text countDownText;

    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countDownText.text = currentTime.ToString("0");
       // Debug.Log(currentTime);

        if(currentTime <= 0f)
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
