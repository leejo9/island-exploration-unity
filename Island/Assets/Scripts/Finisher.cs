using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finisher : MonoBehaviour
{
    public Timer timer;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Pick Up")
        {
            timer.Finnish();
        }
    }
}
