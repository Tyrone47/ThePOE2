using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject sorryBruCanvas;
    public GameObject gameSelectionCanvas;
    public void DisplayDialogue()
    {
        sorryBruCanvas.SetActive(true);
        gameSelectionCanvas.SetActive(false);
    }

    public void HideDialogue()
    {
        sorryBruCanvas.SetActive(false);
        gameSelectionCanvas.SetActive(true);
    }

    // Start is called before the first frame update
    public void MoveScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
