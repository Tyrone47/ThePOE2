using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialManager : MonoBehaviour
{

    public string filePath;
    public RectTransform dial_panel;
    private Queue<NewDialogue> dc;
    public bool open_on_start = false;

    // Start is called before the first frame update
    void Start()
    {
        if(filePath != null)
        {
            dc = JSONReader.read(filePath);
            if (open_on_start)
            {
                startDialogue();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startDialogue()
    {
        dial_panel.gameObject.SetActive(true);
        nextDialogue();
    }

    public void nextDialogue()
    {
        if (dc.hasNext())
        {
            NewDialogue nd = dc.Dequeue();
            dial_panel.GetChild(3).GetComponent<TMPro.TextMeshProUGUI>().text = nd.text;
        }
        else
        {
            dial_panel.gameObject.SetActive(false);
        }
    }
}
