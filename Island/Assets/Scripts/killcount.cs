using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class killcount : MonoBehaviour
{
    public static int score;
    public Text scoret;

    void Start()
    {
        scoret = GetComponent<Text>();
        score = 0;
    }
    void Update()
    {
        scoret.text = "Score: " + score;
    }

}
