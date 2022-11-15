using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] wayPoints;
    private NavMeshAgent agent;
    private int point = 0;
    public GameObject manager;
     
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Debug.Log("");
    }

    // Update is called once per frame
    void Update()
    {
        if (point > 3)
        {
            Debug.Log("Ok Its working");
        }



        if (!agent.pathPending && agent.remainingDistance<0.5f)
        {
            nextPoint();
        }
        Debug.Log(manager.GetComponent<CheckWaypoints>().currentWayPoint);

        
    }

    void nextPoint()
    {
        if (manager.GetComponent<CheckWaypoints>().currentWayPoint == 4)
        {
            point = Random.Range(5,7);
        }
        if (manager.GetComponent<CheckWaypoints>().currentWayPoint == 7)
        {
            point = Random.Range(8,10);
        }
        if (manager.GetComponent<CheckWaypoints>().currentWayPoint == 0)
        {
            point = 1;
        }
        if (manager.GetComponent<CheckWaypoints>().currentWayPoint == 5 || manager.GetComponent<CheckWaypoints>().currentWayPoint == 6)
        {
            point = 7;
        }
        if (manager.GetComponent<CheckWaypoints>().currentWayPoint == 8 || manager.GetComponent<CheckWaypoints>().currentWayPoint == 9)
        {
            point = 10;
        }

        manager.GetComponent<CheckWaypoints>().currentWayPoint = point;
        agent.destination = wayPoints[point].transform.position;
       point = (point + 1) % wayPoints.Length;  
    }
}
