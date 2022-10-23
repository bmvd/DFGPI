using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

// Using the following code for animation : https://www.youtube.com/watch?v=blPglabGueM&list=PLTYqYM0shNgK_tC6zLil8rVqqp1e41AoM&index=3 together with https://www.youtube.com/watch?v=j1-OyLo77ss for fov and 

public class EnemyAI : MonoBehaviour
{

    public ThirdPersonCharacter character;

    [SerializeField] public Transform player; // input of object to trace

    private NavMeshAgent navMeshAgent;

    public LayerMask whatIsGround, whatIsPlayer, whatIsObstacle;

    private float time;
    [Range(1, 100)]
    public int maxTime = 1;


    //Patroling
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    

    //States
    public float sightRange;
    [Range(0,360)]
    public float angle;
    public bool playerInSight;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    private void Start()
    {
        StartCoroutine(FOVRoutine());
        navMeshAgent.updateRotation = false; //don't rotate so third person controller will handle it
    }

    private void Update()
    {
        //playerInSight = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);

        if (playerInSight)
        {
            navMeshAgent.destination = player.position; // move to object}
            navMeshAgent.speed = 0.12f;
        }
        else if (!playerInSight)
        {
            navMeshAgent.speed = 0.06f;
            if (!walkPointSet)
            {
                time = Time.time;
                SearchWalkPoint();
            }

            if (walkPointSet)
                navMeshAgent.SetDestination(walkPoint);

            Vector3 distanceToWalkPoint = transform.position - walkPoint;

            //Walkpoint Reached
            if (distanceToWalkPoint.magnitude < 1f)
                walkPointSet = false;

            if (Time.time > time + maxTime)
            {
                walkPointSet = false;
            }

        }

        if(navMeshAgent.remainingDistance > navMeshAgent.stoppingDistance)
        {
            character.Move(navMeshAgent.desiredVelocity, false, false);
        } else
        {
            character.Move(Vector3.zero, false, false);
        }
        
    }



    private void SearchWalkPoint()
        {
            float randomZ = Random.Range(-walkPointRange, walkPointRange);
            float randomX = Random.Range(-walkPointRange, walkPointRange);

            walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

            if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
                walkPointSet = true;
        }

    private void OnDrawGizmosSelected()
    {

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(walkPoint, 2);
    }

    private IEnumerator FOVRoutine() // Only looks for player 5x per second to reduce load on computer
    {
        WaitForSeconds wait = new WaitForSeconds(0.2f);

        while (true)
        {
            yield return wait;
            FieldOfViewCheck();
        }
    }

    private void FieldOfViewCheck()
    {
        Collider[] rangeChecks = Physics.OverlapSphere(transform.position, sightRange, whatIsPlayer);

        if (rangeChecks.Length != 0)
        {
            Transform target = rangeChecks[0].transform;
            Vector3 directionToTarget = (target.position - transform.position).normalized;

            if (Vector3.Angle(transform.forward, directionToTarget) < angle / 2)
            {
                float distanceToTarget = Vector3.Distance(transform.position, target.position);

                if (!Physics.Raycast(transform.position, directionToTarget, distanceToTarget, whatIsObstacle))
                    playerInSight = true;
                else
                    playerInSight = false;
            }
            else playerInSight = false;
        }
        else if (playerInSight)
            playerInSight = false;
    }
}
