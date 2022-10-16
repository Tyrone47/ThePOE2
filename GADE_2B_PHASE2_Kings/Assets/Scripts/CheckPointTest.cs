using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckPointTest : MonoBehaviour
{

    //private bool PlayerInRange; 
    public TextMeshProUGUI checkpoint;
    public string checkPoint = "CheckPoint!";

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collider)
    {
        
        if (collider.tag == "Player")
        {
            if (checkpoint)
                checkpoint.text = checkPoint;
            else
                Debug.Log("test");
        }
            //PlayerInRange = true;         
    }

    public void Update()
    {
        
    }
}
