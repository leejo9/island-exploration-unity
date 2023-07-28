using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject projectile;
    public float launchVelocity = 700f;
    public float interval =0;
    public float cd =2;
    public AudioSource laser;

    void Update()
    {
        if (Time.time > interval)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                laser.Play();
                GameObject ball = Instantiate(projectile, transform.position,transform.rotation);
                ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(launchVelocity, launchVelocity / 6, 0));
                Destroy(ball, 2f);
                interval = Time.time + cd;
            }

        } 

    }
    
}
