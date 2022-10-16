using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] wayPoints;
    private NavMeshAgent agent;
    private int point = 0;
   
     
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Debug.Log("awe");
    }

    // Update is called once per frame
    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance<0.5f)
        {
            nextPoint();
        }
    }

    void nextPoint()
    {
        agent.destination = wayPoints[point].position;
       point = (point + 1) % wayPoints.Length;  
    }
}
