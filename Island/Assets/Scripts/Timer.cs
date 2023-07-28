using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float starttime;
    private static bool finnished = false;
    // Start is called before the first frame update
    void Start()
    {
        finnished = false;
        starttime = Time.time;
    }

    // Update is called once per frame
    void Update() 
    {
        if (finnished)
        {
            return;
        }
        else
        {
            float t = Time.time - starttime;
            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f2");
            timerText.text = minutes + ":" + seconds;
        }
    }
    public void Finnish()
    {
        finnished = true;
        timerText.color = Color.green;
    }
}
