using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWaypoints : MonoBehaviour
{
    // Start is called before the first frame update
    public int currentWayPoint;
    public int random;
    public bool shortcut = false;
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player")
        {
            
            return;
        }
        
        Debug.Log("Player Waypoint reached");
        other.gameObject.GetComponent<Animator>().SetInteger("countPoint", currentWayPoint);
        Debug.Log(currentWayPoint);
    }
}
