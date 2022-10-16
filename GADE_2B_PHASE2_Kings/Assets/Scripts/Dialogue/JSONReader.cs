using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONReader
{

    public static Queue<NewDialogue> read(string filePath)
    {
        Queue<NewDialogue> q = new Queue<NewDialogue>();

        TextAsset text = (TextAsset)Resources.Load(filePath);
        DialogueContainer dc = JsonUtility.FromJson<DialogueContainer>(text.text);

        foreach(NewDialogue dialogue in dc.container)
        {
            q.Enqueue(dialogue);
        }

        return q;
    }
   

}
