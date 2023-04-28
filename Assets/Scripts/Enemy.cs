using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public LayerMask playerLayer, groundLayer;

    public float enemyHealth = 100f;
    public float attackRange;
    public float detectionRange;
    public float attackCooldown = 3f;
    private float nextAttackTime;

    void Start()
    {
        player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (enemyHealth <= 0)
        {
            // Destroy the enemy
            Destroy(gameObject);
        }
        else if (distance <= detectionRange)
        {
            agent.SetDestination(player.position);

            if (distance <= attackRange)
            {
                FaceTarget();

                if (Time.time >= nextAttackTime)
                {
                    AttackPlayer();
                    nextAttackTime = Time.time + attackCooldown;
                }
            }
        }
    }

    void FaceTarget()
    {
        Vector3 direction = (player.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0f, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    void AttackPlayer()
    {
        // Placeholder for attack logic
        // Damage the player or play attack animation and apply damage using events or triggers
        Debug.Log("Attacking player!");
    }

    public void TakeDamage(float damage)
    {
        enemyHealth -= damage;
    }
}
