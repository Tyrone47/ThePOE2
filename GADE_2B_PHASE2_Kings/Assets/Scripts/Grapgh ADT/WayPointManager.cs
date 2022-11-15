using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointManager : MonoBehaviour
{
    public GameObject[] points;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 GetWayPoints(int point , bool pointB = false)
    {
        foreach (GameObject p in points)
        {
            if (p.GetComponent<CheckWaypoints>().currentWayPoint == point && p.GetComponent<CheckWaypoints>().shortcut == pointB)
            {
                return p.transform.position;
            }
        }
        return new Vector3();
    }
}
