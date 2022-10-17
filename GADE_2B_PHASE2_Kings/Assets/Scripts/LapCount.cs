using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class LapCount : MonoBehaviour
{
    public int lapCount = 0;
    public GameObject player;
    public TextMeshProUGUI lapDisplay;
    public TextMeshProUGUI gameDoneDisplay;
    public int playerPosition;
    public int playerPosition2;
    public int playerPosition3;
    public int playerPosition4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        lapDisplay.text = "Laps: " + lapCount.ToString() + "/3";
        if (other.tag == "Player")
        {
            lapCount++;
        }
        if (lapCount == 4)
        {
            gameDoneDisplay.text = "Race Completed";
            Time.timeScale = 0.0001f;
        }
    }
}
