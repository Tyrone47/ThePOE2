using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;


//int moveSpeed = 4;

public class Move : MonoBehaviour
{

    public GameObject RaceCar;
    // Start is called before the first frame update
    void Start()
    {
        //RaceCar.transform.Rotate(-90f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.left * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.down * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.up * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.right * Time.deltaTime);
        }
    }
}
