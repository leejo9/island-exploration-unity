using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class aishoot : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform player;
    public float launchVelocity = 700f;

    public project proj;

    //Check for Ground/Obstacles
    public LayerMask whatIsGround, whatIsPlayer;


    //Attack Player
    public float timeBetweenAttacks;
    bool alreadyAttacked;

    //States
    public bool isDead;
    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;

    //Special
    public GameObject projectile;


    private void Update()
    {
        if (!isDead)
        {
            playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);

            //Check if Player in attackrange
            playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

            if (playerInAttackRange && playerInSightRange) AttackPlayer();
        }
    }

    private void AttackPlayer()
    {
        if (isDead) return;

        //Make sure enemy doesn't move
        agent.SetDestination(transform.position);

        if (!alreadyAttacked)
        {

            GameObject ball = Instantiate(projectile, transform.position, transform.rotation);
            ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(launchVelocity, launchVelocity / 35, 0));
            Destroy(ball, 2f);
            alreadyAttacked = true;
            Invoke("ResetAttack", timeBetweenAttacks);

        }

    }

    public void stopEnemy()
    {
        agent.isStopped = true;
    }
    private void ResetAttack()
    {
        if (isDead) return;

        alreadyAttacked = false;
    }

}