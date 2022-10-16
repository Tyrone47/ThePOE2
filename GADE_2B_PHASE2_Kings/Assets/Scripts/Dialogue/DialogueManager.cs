using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI playerName;
    public TextMeshProUGUI descriptionText;
    private Queue<string> sentences;
    public GameObject npcConvo;

    void Start()
    {
        sentences = new Queue<string>();
        npcConvo.SetActive(false);
    }

    
    public void StartDialogue(Dialogue dialogue)
    {

        Debug.Log("Ayy, " + dialogue.name + "! You ready to start out this checkpoint race?!");
        //sentences.Clear();

        playerName.text = dialogue.name;
        
        foreach (string sentence in dialogue.broersText)
        {
            sentences.Enqueue(sentence);
        }
        
        //NextDialogue();
       
    }
    /*public void NextDialogue()
    {
        if (sentences.Count==0)
        {
            EndDialogue();
            npcConvo.SetActive(true);
            return;
        }
        string sentence =  sentences.Dequeue();
        Debug.Log(sentence);
        descriptionText.text = sentence;
       // descriptionText.text = sentence;
    }

    void EndDialogue()
    {
        
        Debug.Log("End of Convo");
        npcConvo?.SetActive(false);
    
    }*/
    

}
