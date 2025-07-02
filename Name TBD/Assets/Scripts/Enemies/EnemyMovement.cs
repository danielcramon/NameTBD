using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform target;
    [SerializeField] NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        if (!agent)
        {
            gameObject.GetComponent<NavMeshAgent>();
        }

        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);

        if ((agent.transform.position - target.position).magnitude < 1.5f)
        {
            agent.SetDestination(agent.transform.position);
        }
    }
}
