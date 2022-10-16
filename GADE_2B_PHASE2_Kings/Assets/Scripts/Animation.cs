using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{

    public GameObject anim1;
    public GameObject anim2;
    public GameObject anim3;
    private int period = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        period++;
        if(period > 300)
        {
            int range = Random.Range(0, 4);
            if(range == 1)
            {
                anim1.GetComponent<Animator>().Play("Cheer1");
                anim2.GetComponent<Animator>().Play("Cheer2");
                anim3.GetComponent<Animator>().Play("Cheer3");
                Debug.Log("first");
            }
            else if (range == 2)
            {
                anim1.GetComponent<Animator>().Play("Cheer2");
                anim2.GetComponent<Animator>().Play("Cheer1");
                anim3.GetComponent<Animator>().Play("Cheer2");
                Debug.Log("second");
            }
            else if (range == 3)
            {
                anim1.GetComponent<Animator>().Play("Cheer3");
                anim2.GetComponent<Animator>().Play("Cheer3");
                anim3.GetComponent<Animator>().Play("Cheer1");
                Debug.Log("third");
            }
            period = 0;
        }
        
    }

    
}
