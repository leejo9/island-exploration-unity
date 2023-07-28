using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class project : MonoBehaviour
{
    public GameObject projectile;
    public float launchVelocity = 700f;

    void fire()
    {
        if (Input.GetButtonDown("Fire1"))
        {

            GameObject ball = Instantiate(projectile, transform.position,
                                                          transform.rotation);
            ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3
                                                 (launchVelocity, launchVelocity / 12, 0));
            Destroy(ball, 2f);


        }

    }

}
